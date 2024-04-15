using libdebug;

namespace PS4_Cheat_Engine {

    public interface PS4APIWarpper {

        void Connect();

        ProcessInfo GetProcessInfo(int pid);

        ProcessList GetProcessList();
    }
}