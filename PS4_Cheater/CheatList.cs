using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace PS4_Cheater {

    public enum ArithmeticType {
        ADD_TYPE,
        SUB_TYPE,
        MUL_TYPE,
        DIV_TYPE,
    }

    public enum CheatOperatorType {
        DATA_TYPE,
        OFFSET_TYPE,
        ADDRESS_TYPE,
        SIMPLE_POINTER_TYPE,
        POINTER_TYPE,
        ARITHMETIC_TYPE,
    }

    public enum CheatType {
        DATA_TYPE,
        SIMPLE_POINTER_TYPE,
        NONE_TYPE,
    }

    public enum ToStringType {
        DATA_TYPE,
        ADDRESS_TYPE,
        ARITHMETIC_TYPE,
    }

    public class AddressCheatOperator : CheatOperator {
        private const int ADDRESS_OFFSET = 1;
        private const int SECTION_ID = 0;

        public AddressCheatOperator(ulong Address, ProcessManager processManager)
            : base(ValueType.ULONG_TYPE, processManager) {
            this.Address = Address;
            CheatOperatorType = CheatOperatorType.ADDRESS_TYPE;
        }

        public AddressCheatOperator(ProcessManager processManager)
            : base(ValueType.ULONG_TYPE, processManager) {
            CheatOperatorType = CheatOperatorType.ADDRESS_TYPE;
        }

        public ulong Address { get; set; }

        public override string Display() {
            return Address.ToString("X");
        }

        public override string Dump(bool simpleFormat) {
            string save_buf = "";

            int sectionID = ProcessManager.MappedSectionList.GetMappedSectionID(Address);
            MappedSection mappedSection = ProcessManager.MappedSectionList[sectionID];
            save_buf += String.Format("@{0:X}", Address) + "_";
            save_buf += sectionID + "_";
            save_buf += String.Format("{0:X}", Address - mappedSection.Start);
            return save_buf;
        }

        public string DumpOldFormat() {
            string save_buf = "";

            int sectionID = ProcessManager.MappedSectionList.GetMappedSectionID(Address);
            MappedSection mappedSection = ProcessManager.MappedSectionList[sectionID];
            save_buf += sectionID + "|";
            save_buf += String.Format("{0:X}", Address - mappedSection.Start) + "|";
            return save_buf;
        }

        public override byte[] Get(int idx = 0) {
            return BitConverter.GetBytes(Address);
        }

        public override byte[] GetRuntime() {
            return MemoryHelper.ReadMemory(Address, MemoryHelper.Length);
        }

        public override int GetSectionID() {
            return ProcessManager.MappedSectionList.GetMappedSectionID(Address);
        }

        public override bool Parse(string[] cheat_elements, ref int start_idx, bool simple_format) {
            if (simple_format) {
                string address = cheat_elements[start_idx++];
                string[] address_elements = address.Split('_');

                int sectionID = int.Parse(address_elements[1]);
                if (sectionID >= ProcessManager.MappedSectionList.Count || sectionID < 0) {
                    return false;
                }

                ulong addressOffset = ulong.Parse(address_elements[2], NumberStyles.HexNumber);

                Address = addressOffset + ProcessManager.MappedSectionList[sectionID].Start;
            }
            return false;
        }

        public bool ParseOldFormat(string[] cheat_elements, ref int start_idx) {
            int sectionID = int.Parse(cheat_elements[start_idx + SECTION_ID]);
            if (sectionID >= ProcessManager.MappedSectionList.Count || sectionID < 0) {
                return false;
            }

            ulong addressOffset = ulong.Parse(cheat_elements[start_idx + ADDRESS_OFFSET], NumberStyles.HexNumber);

            Address = addressOffset + ProcessManager.MappedSectionList[sectionID].Start;

            start_idx += 2;
            return true;
        }

        public override void Set(CheatOperator SourceCheatOperator, int idx = 0) {
            Address = BitConverter.ToUInt64(SourceCheatOperator.Get(), 0);
        }

        public override void SetRuntime(CheatOperator SourceCheatOperator, int idx = 0) {
            MemoryHelper.WriteMemory(Address, SourceCheatOperator.GetRuntime());
        }

        public override string ToString() {
            return Address.ToString("X");
        }
    }

    public class BinaryArithmeticCheatOperator : CheatOperator {

        public BinaryArithmeticCheatOperator(CheatOperator left, CheatOperator right, ArithmeticType ArithmeticType,
            ProcessManager processManager)
            : base(left.ValueType, processManager) {
            Left = left;
            Right = right;
            this.ArithmeticType = ArithmeticType;
            CheatOperatorType = CheatOperatorType.ARITHMETIC_TYPE;
        }

        public CheatOperator Left { get; set; }
        public CheatOperator Right { get; set; }

        private ArithmeticType ArithmeticType { get; set; }

        public override string Display() {
            return "";
        }

        public override string Dump(bool simpleFormat) {
            return Left.Dump(simpleFormat) + Right.Dump(simpleFormat);
        }

        public override byte[] Get(int idx) {
            if (idx == 0)
                return Left.Get();
            return Right.Get();
        }

        public byte[] GetRuntime(int idx) {
            // Allocate memory for left and right buffers
            byte[] left_buf = new byte[MemoryHelper.Length];
            byte[] right_buf = new byte[MemoryHelper.Length];

            // Copy left and right values into buffers
            Buffer.BlockCopy(Left.Get(), 0, left_buf, 0, MemoryHelper.Length);
            Buffer.BlockCopy(Right.Get(), 0, right_buf, 0, MemoryHelper.Length);

            // Convert bytes to ulong for arithmetic operations
            ulong left = BitConverter.ToUInt64(left_buf, 0);
            ulong right = BitConverter.ToUInt64(right_buf, 0);
            ulong result = 0;

            // Perform arithmetic calculation based on the provided type
            switch (ArithmeticType) {
                case ArithmeticType.ADD_TYPE: result = left + right; break;
                case ArithmeticType.SUB_TYPE: result = left - right; break;
                case ArithmeticType.MUL_TYPE: result = left * right; break;
                case ArithmeticType.DIV_TYPE: result = left / right; break;
                default:
                    // Handle unknown arithmetic types by throwing an exception
                    throw new Exception("Warning! The Arithmetic type is not one of the following types:\n" +
                                        "Addition, Subtraction, Multiplication, or Division");
            };

            // Convert the result back to byte array and return
            return MemoryHelper.StringToBytes(result.ToString());
        }

        public override bool Parse(string[] cheat_elements, ref int start_idx, bool simple_format) {
            if (Left.Parse(cheat_elements, ref start_idx, simple_format)) {
                Console.WriteLine("Unable to parse cheat elements! - Parse()");
                return false;
            }

            switch (cheat_elements[start_idx]) {
                case "+": ArithmeticType = ArithmeticType.ADD_TYPE; break;
                case "-": ArithmeticType = ArithmeticType.SUB_TYPE; break;
                case "*": ArithmeticType = ArithmeticType.MUL_TYPE; break;
                case "/": ArithmeticType = ArithmeticType.DIV_TYPE; break;

                default:
                    // Handle unknown arithmetic calculation types by throwing an exception
                    throw new Exception("Warning! in Parse() function - Unknown Arithmetic Type");
            };

            ++start_idx;

            if (Right.Parse(cheat_elements, ref start_idx, simple_format)) {
                return false;
            }

            return true;
        }

        public override void Set(CheatOperator SourceCheatOperator, int idx = 0) {
            throw new Exception("Set BinaryArithmeticCheatOperator");
        }

        public override void SetRuntime(CheatOperator SourceCheatOperator, int idx = 0) {
            throw new Exception("SetRuntime BinaryArithmeticCheatOperator");
        }
    }

    public class Cheat {
        protected ProcessManager ProcessManager;

        public Cheat(ProcessManager ProcessManager) {
            this.ProcessManager = ProcessManager;
        }

        public bool AllowLock { get; set; }
        public CheatType CheatType { get; set; }
        public string Description { get; set; }

        public bool Lock { get; set; }
        protected CheatOperator Destination { get; set; }
        protected CheatOperator Source { get; set; }

        /// <summary> Returns the Current value of [Destination] </summary>
        public CheatOperator GetDestination() => Destination;

        /// <summary> Returns the Current value of [Source] </summary>
        public CheatOperator GetSource() => Source;

        /// <summary> Returns false, whats the point of this function lol? </summary>
        public virtual bool Parse(string[] cheat_elements) => false;
    }

    public class CheatOperator {
        protected MemoryHelper MemoryHelper = new MemoryHelper(true, 0);

        private ValueType _valueType;

        public CheatOperator(ValueType valueType, ProcessManager processManager) {
            ProcessManager = processManager;
            ValueType = valueType;
        }

        public CheatOperatorType CheatOperatorType { get; set; }
        public ProcessManager ProcessManager { get; set; }

        public ValueType ValueType {
            get {
                return _valueType;
            }
            set {
                _valueType = value;
                MemoryHelper.InitMemoryHandler(ValueType, CompareType.NONE, false);
            }
        }

        /// <summary> Returns null always, whats the point of this? </summary
        public virtual string Display() => null;

        /// <summary> Returns false, whats the point of this function lol? </summary>
        public virtual string Dump(bool simpleFormat) => null;

        /// <summary> Returns null always, whats the point of this? </summary
        public virtual byte[] Get(int idx = 0) => null;

        /// <summary> Returns null always, whats the point of this? </summary
        public virtual byte[] GetRuntime() => null;

        /// <summary> Returns -1 always, whats the point of this? </summary
        public virtual int GetSectionID() => -1;

        /// <summary> Returns false always, whats the point of this? </summary
        public virtual bool Parse(string[] cheat_elements, ref int start_idx, bool simple_format)
            => false;

        /// <summary> This function does nothing whats the point? </summary>
        public virtual void Set(CheatOperator SourceCheatOperator, int idx = 0) { }

        /// <summary> This function does nothing whats the point? </summary>
        public virtual void SetRuntime(CheatOperator SourceCheatOperator, int idx = 0) { }

        /// <summary> Returns null always, whats the point of this? </summary
        public virtual string ToString(bool simple)
            => null;
    }

    public class DataCheat : Cheat {
        private const int CHEAT_CODE_DATA_TYPE_DESCRIPTION = 6;
        private const int CHEAT_CODE_DATA_TYPE_ELEMENT_COUNT = CHEAT_CODE_DATA_TYPE_DESCRIPTION + 1;
        private const int CHEAT_CODE_DATA_TYPE_FLAG = 5;

        public DataCheat(DataCheatOperator source, AddressCheatOperator dest, bool lock_, string description, ProcessManager processManager)
            : base(processManager) {
            CheatType = CheatType.DATA_TYPE;
            AllowLock = true;
            Source = source;
            Destination = dest;
            Lock = lock_;
            Description = description;
        }

        public DataCheat(ProcessManager ProcessManager) :
            base(ProcessManager) {
            Source = new DataCheatOperator(ProcessManager);
            Destination = new AddressCheatOperator(ProcessManager);
            CheatType = CheatType.DATA_TYPE;
            AllowLock = true;
        }

        public override bool Parse(string[] cheat_elements) {
            if (cheat_elements.Length < CHEAT_CODE_DATA_TYPE_ELEMENT_COUNT) {
                return false;
            }

            int start_idx = 1;
            AddressCheatOperator addressCheatOperator = (AddressCheatOperator)Destination;
            if (!(addressCheatOperator.ParseOldFormat(cheat_elements, ref start_idx))) {
                return false;
            }

            if (!Source.Parse(cheat_elements, ref start_idx, true)) {
                return false;
            }

            ulong flag = ulong.Parse(cheat_elements[CHEAT_CODE_DATA_TYPE_FLAG], NumberStyles.HexNumber);

            Lock = flag == 1 ? true : false;

            Description = cheat_elements[CHEAT_CODE_DATA_TYPE_DESCRIPTION];

            Destination.ValueType = Source.ValueType;

            return true;
        }

        public override string ToString() {
            string save_buf = "";
            save_buf += "data|";
            save_buf += ((AddressCheatOperator)Destination).DumpOldFormat();
            save_buf += Source.Dump(true);
            save_buf += (Lock ? "1" : "0") + "|";
            save_buf += Description + "|";
            save_buf += Destination.ToString() + "\n";
            return save_buf;
        }
    }

    public class DataCheatOperator : CheatOperator {
        private const int DATA = 1;
        private const int DATA_TYPE = 0;
        private byte[] data;

        public DataCheatOperator(string data, ValueType valueType, ProcessManager processManager)
            : base(valueType, processManager) {
            this.data = MemoryHelper.StringToBytes(data);
            CheatOperatorType = CheatOperatorType.DATA_TYPE;
        }

        public DataCheatOperator(byte[] data, ValueType valueType, ProcessManager processManager)
            : base(valueType, processManager) {
            this.data = data;
            CheatOperatorType = CheatOperatorType.DATA_TYPE;
        }

        public DataCheatOperator(ProcessManager processManager)
            : base(ValueType.NONE_TYPE, processManager) {
            CheatOperatorType = CheatOperatorType.DATA_TYPE;
        }

        public override string Display() {
            return MemoryHelper.BytesToString(data);
        }

        public override string Dump(bool simpleFormat) {
            string save_buf = "";
            save_buf += MemoryHelper.GetStringOfValueType(ValueType) + "|";
            save_buf += MemoryHelper.BytesToString(data) + "|";
            return save_buf;
        }

        public override byte[] Get(int idx = 0) {
            return data;
        }

        public override byte[] GetRuntime() {
            return data;
        }

        public override bool Parse(string[] cheat_elements, ref int start_idx, bool simple_format) {
            ValueType = MemoryHelper.GetValueTypeByString(cheat_elements[start_idx + DATA_TYPE]);
            data = MemoryHelper.StringToBytes(cheat_elements[start_idx + DATA]);
            start_idx += 2;
            return true;
        }

        public override void Set(CheatOperator SourceCheatOperator, int idx = 0) {
            data = new byte[MemoryHelper.Length];
            Buffer.BlockCopy(SourceCheatOperator.Get(), 0, data, 0, MemoryHelper.Length);
        }

        public void Set(string data) {
            this.data = MemoryHelper.StringToBytes(data);
        }

        public void Set(byte[] data) {
            this.data = data;
        }

        public override void SetRuntime(CheatOperator SourceCheatOperator, int idx = 0) {
            data = new byte[MemoryHelper.Length];
            Buffer.BlockCopy(SourceCheatOperator.GetRuntime(), 0, data, 0, MemoryHelper.Length);
        }

        public override string ToString(bool simple) {
            return MemoryHelper.BytesToString(data);
        }
    }

    public class OffsetCheatOperator : CheatOperator {

        public OffsetCheatOperator(long offset, ValueType valueType, ProcessManager processManager)
            : base(valueType, processManager) {
            this.Offset = offset;
            CheatOperatorType = CheatOperatorType.OFFSET_TYPE;
        }

        public OffsetCheatOperator(ProcessManager processManager)
            : base(ValueType.NONE_TYPE, processManager) {
            CheatOperatorType = CheatOperatorType.OFFSET_TYPE;
        }

        public long Offset { get; set; }

        public override string Display() {
            return Offset.ToString("X16");
        }

        public override string Dump(bool simpleFormat) {
            string save_buf = "";
            save_buf += "+";
            save_buf += Offset.ToString("X");
            return save_buf;
        }

        public override byte[] Get(int idx = 0) {
            return BitConverter.GetBytes(Offset);
        }

        public override byte[] GetRuntime() {
            return BitConverter.GetBytes(Offset);
        }

        public override bool Parse(string[] cheat_elements, ref int start_idx, bool simple_format) {
            Offset = Int64.Parse(cheat_elements[start_idx], NumberStyles.HexNumber);
            start_idx += 1;
            return true;
        }

        public override void Set(CheatOperator SourceCheatOperator, int idx = 0) {
            Offset = BitConverter.ToInt64(SourceCheatOperator.Get(), 0);
        }

        public void Set(long offset) {
            this.Offset = offset;
        }

        public override void SetRuntime(CheatOperator SourceCheatOperator, int idx = 0) {
            Offset = BitConverter.ToInt64(SourceCheatOperator.Get(), 0);
        }

        public override string ToString(bool simple) {
            return Offset.ToString("X16");
        }
    }

    public class SimplePointerCheat : Cheat {

        public SimplePointerCheat(ProcessManager ProcessManager)
            : base(ProcessManager) {
            CheatType = CheatType.SIMPLE_POINTER_TYPE;
            AllowLock = true;
        }

        public SimplePointerCheat(CheatOperator source, CheatOperator dest, bool lock_, string description, ProcessManager processManager)
            : base(processManager) {
            CheatType = CheatType.DATA_TYPE;
            AllowLock = true;
            Source = source;
            Destination = dest;
            Lock = lock_;
            Description = description;
        }

        public override bool Parse(string[] cheat_elements) {
            int start_idx = 1;

            if (cheat_elements[start_idx] == "address") {
                Destination = new AddressCheatOperator(ProcessManager);
            }
            else if (cheat_elements[start_idx] == "pointer") {
                Destination = new SimplePointerCheatOperator(ProcessManager);
            }

            ++start_idx;
            Destination.Parse(cheat_elements, ref start_idx, true);

            if (cheat_elements[start_idx] == "data") {
                Source = new DataCheatOperator(ProcessManager);
            }
            else if (cheat_elements[start_idx] == "pointer") {
                Source = new SimplePointerCheatOperator(ProcessManager);
            }

            ++start_idx;
            Source.Parse(cheat_elements, ref start_idx, true);

            ulong flag = ulong.Parse(cheat_elements[start_idx], NumberStyles.HexNumber);

            Lock = flag == 1 ? true : false;

            Description = cheat_elements[start_idx + 1];

            return true;
        }

        public override string ToString() {
            // If the cheat is locked or not
            string should_lock = Lock ? "1" : "0";

            // Build new cheat list entry?
            string save_buf = "";
            save_buf += $"simple pointer|pointer|{Destination.Dump(true)}|data|{Source.Dump(true)}";
            save_buf += $"{should_lock}|{Description}|\n";

            // Return the newly built cheat entry
            return save_buf;
        }
    }

    public class SimplePointerCheatOperator : CheatOperator {

        public SimplePointerCheatOperator(AddressCheatOperator Address, List<OffsetCheatOperator> Offsets, ValueType valueType, ProcessManager processManager)
            : base(valueType, processManager) {
            this.Address = Address;
            this.Offsets = Offsets;
            CheatOperatorType = CheatOperatorType.SIMPLE_POINTER_TYPE;
        }

        public SimplePointerCheatOperator(ProcessManager processManager)
            : base(ValueType.NONE_TYPE, processManager) {
            Address = new AddressCheatOperator(ProcessManager);
            Offsets = new List<OffsetCheatOperator>();

            CheatOperatorType = CheatOperatorType.SIMPLE_POINTER_TYPE;
        }

        private AddressCheatOperator Address { get; set; }
        private List<OffsetCheatOperator> Offsets { get; set; }

        /** <summary> Returns a value in following format: "p->(hexadecimal value here)" </summary> **/

        public override string Display() => $"p->{GetAddress():X}";

        // TODO: Comment this function
        public override byte[] Get(int idx = 0) => Address.Get();

        // TODO: Comment this function
        public override string Dump(bool simpleFormat) {
            string dump_buf;

            // First we append the string form of the <valueType> an example of
            // this is "8 bytes", followed by "|"
            dump_buf = $"{MemoryHelper.GetStringOfValueType(ValueType)}|";
            dump_buf += Address.Dump(simpleFormat);

            // Then we append each offset to the dump string buffer
            for (int i = 0; i < Offsets.Count; ++i) {
                dump_buf += Offsets[i].Dump(simpleFormat);
            }

            // Then we return the dump buffer
            return dump_buf;
        }

        public override byte[] GetRuntime() {
            return MemoryHelper.ReadMemory(GetAddress(), MemoryHelper.Length);
        }

        public override int GetSectionID() {
            return ProcessManager.MappedSectionList.GetMappedSectionID(GetAddress());
        }

        public override bool Parse(string[] cheat_elements, ref int start_idx, bool simple_format) {
            // Get the value's type using the <start_idx> as the array entry
            ValueType = MemoryHelper.GetValueTypeByString(cheat_elements[start_idx]);

            // Create an array of offsets, using each offset whose seperated with "+"
            // for example: 0x32+0x21+0x11, will become:
            // pointer_list[0] => 0x32
            // pointer_list[1] => 0x21
            // pointer_list[2] => 0x11
            string[] pointer_list = cheat_elements[start_idx + 1].Split('+');

            int pointer_idx = 0;

            Address.Parse(pointer_list, ref pointer_idx, simple_format);

            for (int i = 1; i < pointer_list.Length; ++i) {
                // Is creating a new <OffsetCheatOperator> per offset necessary?
                OffsetCheatOperator offset = new OffsetCheatOperator(ProcessManager);

                // Handle the case of Parse returning false/error
                if (!offset.Parse(pointer_list, ref pointer_idx, simple_format)) {
                    // Print out error message
                    Console.WriteLine($"Unable to parse Offset from pointer list index {i}!!!");
                }

                // Append the current offset to the <Offsets> list
                Offsets.Add(offset);
            }

            start_idx += 2;

            return true;
        }

        public override void Set(CheatOperator SourceCheatOperator, int idx = 0) {
            throw new Exception("Pointer Set!!");
        }

        public override void SetRuntime(CheatOperator SourceCheatOperator, int idx = 0) {
            byte[] buf = new byte[MemoryHelper.Length];
            Buffer.BlockCopy(SourceCheatOperator.GetRuntime(), 0, buf, 0, MemoryHelper.Length);

            MemoryHelper.WriteMemory(GetAddress(), buf);
        }

        private ulong GetAddress() {
            // Get the base address?
            ulong address = BitConverter.ToUInt64(Address.GetRuntime(), 0);

            // current offset index (used in for-loop)
            int offset_idx;

            // Loop through offsets and calculate the final address
            for (offset_idx = 0; offset_idx < Offsets.Count - 1; ++offset_idx) {
                // Read memory, then Convert the read memory byte array to Unsigned 64-bit integer
                address = BitConverter.ToUInt64(
                    MemoryHelper.ReadMemory((ulong)((long)address + Offsets[offset_idx].Offset), 8),
                    0
                );
            }

            // If the last used index value is less than the number of offsets present
            // in the <Offsets> list, then add the offset present in current index
            if (offset_idx < Offsets.Count) address += (ulong)Offsets[offset_idx].Offset;

            // Then return the address
            return address;
        }
    }

    internal class CheatList {
        private const int CHEAT_CODE_HEADER_ELEMENT_COUNT = CHEAT_CODE_HEADER_PROCESS_NAME + 1;
        private const int CHEAT_CODE_HEADER_PROCESS_ID = 2;
        private const int CHEAT_CODE_HEADER_PROCESS_NAME = 1;
        private const int CHEAT_CODE_HEADER_PROCESS_VER = 3;
        private const int CHEAT_CODE_HEADER_VERSION = 0;
        private const int CHEAT_CODE_TYPE = 0;
        private List<Cheat> cheat_list;

        public CheatList() {
            cheat_list = new List<Cheat>();
        }

        /// <summary> Upon [Count] being accessed, the number of items present in [cheat_list] is returned </summary>
        public int Count {
            get { return cheat_list.Count; }
        }

        // TODO: Comment this part
        public Cheat this[int index] {
            get { return cheat_list[index]; }
            set { cheat_list[index] = value; }
        }

        public void Add(Cheat cheat) {
            Console.WriteLine("Adding new cheat item to <cheat_list>!");
            cheat_list.Add(cheat);
        }

        public void Clear() {
            Console.WriteLine("Clearing the <cheat_list>!");
            cheat_list.Clear();
        }

        /// <summary> What's the point of this, if it just returns false lol </summary>
        public bool Exist(Cheat cheat) => false;

        /// <summary> And the same for this, whats the point?? </summary>
        public bool Exist(ulong destAddress) => false;

        /// <summary> Used to load/import a local cheat table file into the cheater </summary>
        public bool LoadFile(string path, ProcessManager processManager, ComboBox comboBox) {
            // Make sure that the file specified by <path> exists, and handle if it does
            // not exist, by printing error message and returning false
            if (!File.Exists(path)) {
                Console.WriteLine($"Cheat Table specified by the path {path} does not exist!");
                return false;
            }

            // Otherwise if the file exists, then read it's content into an string array
            string[] cheats = File.ReadAllLines(path);

            // If the length of the file's content is less than 2 characters? we print
            // error message before returning false
            if (cheats.Length < 2) {
                Console.WriteLine("The File content of the Cheat Table File with path {path} is less than 2");
                return false;
            }

            string header = cheats[0];

            // Create an array from all the values present in cheats first line of the
            // cheat table file that we just read. Extracting each value seperated by
            // the "|" character into seperate array entries
            string[] header_items = header.Split('|');

            // If the newly built array contains less entries than the value specified
            // by <CHEAT_CODE_HEADER_ELEMENT_COUNT>, we print error message before
            // returning false
            if (header_items.Length < CHEAT_CODE_HEADER_ELEMENT_COUNT) {
                Console.WriteLine(
                    $"LoadFile() - Path {path} | Warning Occured!!!\n" +
                    "The number of items in <header_items> array is less than the value specified by" +
                    "CHEAT_CODE_HEADER_ELEMENT_COUNT"
                );
                return false;
            }

            // Removed unnecessary parenthesis
            string[] version = header_items[CHEAT_CODE_HEADER_VERSION].Split('.');

            ulong secondary_version = 0;
            ulong major_version;

            // TODO: Comment this part
            ulong.TryParse(version[0], out major_version);
            if (version.Length > 1) {
                ulong.TryParse(version[1], out secondary_version);
            }

            // If major version is equal to constant value of Major version, and secondary version
            // is equal to the constant value of secondary version. OR! if the major version is
            // greater than that of the major version constant we return false
            if (major_version == CONSTANT.MAJOR_VERSION && secondary_version > CONSTANT.SECONDARY_VERSION ||
                major_version > CONSTANT.MAJOR_VERSION) {
                return false;
            }

            // Now we obtain the Process name, which is stored within the <header_items> array.
            // This is the process name which the offset was found in?
            string process_name = header_items[CHEAT_CODE_HEADER_PROCESS_NAME];

            // If the process name, is not equal to the selected item from the combobox
            // then we set the selected item in the combobox to the process name
            if (process_name != (string)comboBox.SelectedItem)
                comboBox.SelectedItem = process_name;

            // If statement again? why? I guess if the current selected item in the combobox
            // still is not equal to the process name, show error message box and then we
            // return false.
            if (process_name != (string)comboBox.SelectedItem) {
                // Changed the message to be displayed to include the selected item name, and
                // the current process name in question
                MessageBox.Show(
                    $"LoadFile() - Path {path} | An Warning Occured!!!\n" +
                    $"Invalid process ({process_name})!\n" +
                    $"Combobox Selected item is {(string)comboBox.SelectedItem}\n" +
                    "Try to refresh processes first."
                );
                return false;
            }

            // Initialize both the Game CUSA-ID? and Game Version variables in one line
            string game_id = "", game_ver = "";

            // Then attempt to extract the Game CUSA-ID from the <header_items>
            if (header_items.Length > CHEAT_CODE_HEADER_PROCESS_ID) {
                game_id = header_items[CHEAT_CODE_HEADER_PROCESS_ID];
                game_id = game_id.Substring(3);
            }

            // Then attempt to extract the Game Version from the <header_items>
            if (header_items.Length > CHEAT_CODE_HEADER_PROCESS_VER) {
                game_ver = header_items[CHEAT_CODE_HEADER_PROCESS_VER];
                game_ver = game_ver.Substring(4);
            }

            // Once both the Game CUSA-ID and Version has been obtained then we check
            // if both strings are non-empty strings
            if (game_id != "" && game_ver != "") {
                GameInfo gameInfo = new GameInfo();
                // Check if the newly created GameInfo() instance's <GameID> contains
                // a different value than the one present within the imported cheat
                // table file, and handle it in case this is true
                if (gameInfo.GameID != game_id) {
                    var prompt = MessageBox.Show(
                        // Contents of the message box
                        $"Your Game ID ({gameInfo.GameID}) is different from that "+
                        $"specified within the cheat table file which is {game_id}\n"+
                        "Do you still wish to load the table??",
                        // Title of the message box
                        "LoadFile() - Error! GameID mismatch!!!",
                        // Add the Yes or No button to the message box
                        MessageBoxButtons.YesNo
                    );

                    // If the user chose not to load the file, then return early false
                    if (prompt != DialogResult.Yes)
                        return false;
                }

                // Check if the newly created GameInfo() instance's <Version> contains
                // a different value than the one present within the imported cheat
                // table file, and handle it in case this is true
                if (gameInfo.Version != game_ver) {
                    var prompt = MessageBox.Show(
                        // Contents of the message box
                        $"Your Game Version ({gameInfo.Version}) is different than the one "+
                        $"specified in the cheat table file with path ({path}) which is: {game_ver}\n" +
                        "Do you still wish to load the table??",
                        // Title of the message box
                        "LoadFile() - Error! Game Version mismatch!!!",
                        // Add the Yes or No button to the message box
                        MessageBoxButtons.YesNo
                    );

                    // If the user chose not to load the file, then return early false
                    if (prompt != DialogResult.Yes)
                        return false;
                }
            }

            // Otherwise if bot the game id and version matches that which is specified
            // within the loaded cheat table then we begin, parsesing each cheat in the
            // file and add it to the cheat list
            for (int i = 1; i < cheats.Length; ++i) {
                string cheat_tuple = cheats[i];
                string[] cheat_elements = cheat_tuple.Split(
                    new string[] { "|" },
                    StringSplitOptions.None
                );

                if (cheat_elements.Length == 0) {
                    continue;
                }

                // If the Cheat code type specified in the <cheat_elements> is set to "data"
                if (cheat_elements[CHEAT_CODE_TYPE] == "data") {
                    // Then we attempt to create a new DataCheat instance, and then we
                    // add the parsed contents of <cheat_elements>, and handle the case
                    // of there occuring an error while parsing the data, by skipping to
                    // the next cheat element
                    DataCheat cheat = new DataCheat(processManager);
                    if (!cheat.Parse(cheat_elements)) {
                        MessageBox.Show("Invaid cheat code:" + cheat_tuple);
                        continue;
                    }
                    // Otherwise, we append the parsed cheat element to the <cheat_list> array
                    cheat_list.Add(cheat);
                }
                // If the Cheat Code Type in the <cheat_elements> array is set to "simple pointer"
                else if (cheat_elements[CHEAT_CODE_TYPE] == "simple pointer") {
                    // Then we attempt to create a new SimplePointerCheat instance, before we try
                    // and parse the contents of <cheat_elements> to then be added to the newly
                    // created SimplePointerCheat instance, and if the parsing failed, we skip to
                    // the next cheat element
                    SimplePointerCheat cheat = new SimplePointerCheat(processManager);
                    if (!cheat.Parse(cheat_elements))
                        continue;

                    // Otherwise, we append the parsed cheat element to the <cheat_list> array
                    cheat_list.Add(cheat);
                }
                // Otherwise if the Cheat Code type in the <cheat_element> is not set to either
                // "data" or "simple pointer" we call a new message box, before skipping to the
                // next cheat element
                else {
                    MessageBox.Show($"Invaid cheat code: {cheat_tuple} skipping to next element");
                    continue;
                }
            }
            return true;
        }

        public void RemoveAt(int idx) {
            cheat_list.RemoveAt(idx);
        }

        public void SaveFile(string path, string prcessName, ProcessManager processManager) {
            GameInfo gameInfo = new GameInfo();
            string save_buf = CONSTANT.MAJOR_VERSION + "."
                + CONSTANT.SECONDARY_VERSION
                + "|" + prcessName
                + "|ID:" + gameInfo.GameID
                + "|VER:" + gameInfo.Version
                + "|FM:" + Util.Version
                + "\n";

            for (int i = 0; i < cheat_list.Count; ++i) {
                save_buf += cheat_list[i].ToString();
            }

            StreamWriter myStream = new StreamWriter(path);
            myStream.Write(save_buf);
            myStream.Close();
        }
    }
}
