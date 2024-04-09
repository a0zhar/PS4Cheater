using libdebug;

namespace PS4_Cheater {

    public interface PS4APIWarpper {

        void Connect();

        ProcessInfo GetProcessInfo(int pid);

        ProcessList GetProcessList();
    }
}