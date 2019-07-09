using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace MemoryManager
{
    public class Manager
    {
        #region WinApiShit
        //ReadProcessMemory
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadProcessMemory(
                 IntPtr hProcess,
                 IntPtr lpBaseAddress,
                 [Out] byte[] lpBuffer,
                 int dwSize,
                 out int lpNumberOfBytesRead
                );
        //OpenProcess // Flag = All = 0x001F0FFF
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        // CloseHandle
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);
        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORY_BASIC_INFORMATION
        {
            public IntPtr BaseAddress;
            public IntPtr AllocationBase;
            public uint AllocationProtect;
            public IntPtr RegionSize;
            public uint State;
            public uint Protect;
            public uint Type;
        }
        // VirtualQueryEx
        [DllImport("kernel32.dll")]
        static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);
        //WriteProcessMemory
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, uint nSize, UIntPtr lpNumberOfBytesWritten);

        #endregion

        public ProcessModule Module;
        public Process Process;
        public VAMemory VAM;
        public Manager(string ProcessName)
        {
            GetProcessByName("Darkest");
            VAM = new VAMemory(ProcessName);
        }
        private int GetProcessByName(string Name)
        {
            Process Process = Process.GetProcessesByName(Name).FirstOrDefault();
            if (Process != null)
            {
                this.Process = Process;
                return 1;
            }
            else return -1;
        }

        private int GetProcessID()
        {
            return this.Process.Id;

        }

        public Int64 FindSignature()
        {
            string ProcessName = "dota2";
            string ModuleName = "dota2.exe";
            Process = Process.GetProcessesByName(ProcessName)[0];
            Int64 StartAddress = 0;
            Int64 SizeToAllocate = 0;
            int[] Signature = {0xDC, 0x05, 0x00, 0x00, 0xDC, 0x05, 0x00, 0x00, 0x00, 0x02, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00,
                                            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                            0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            if (Process != null)
            {
                foreach (ProcessModule Module in Process.Modules)
                {
                    if (Module.ModuleName == ModuleName)
                    {
                        this.Module = Module;
                        StartAddress = (Int64)Module.BaseAddress;
                        SizeToAllocate = Module.ModuleMemorySize;
                        break;
                    }
                }
                var Handle = OpenProcess(0x001F0FFF, false, Process.Id);
                if (Handle != IntPtr.Zero)
                {
                    byte[] Buffer = new byte[(Int64)SizeToAllocate];
                    int BytesRead;
                    ReadProcessMemory(Handle, Module.BaseAddress, Buffer, (int)SizeToAllocate, out BytesRead);
                    CloseHandle(Handle);
                    int Counter = 0;

                    if (Signature.Length <= Buffer.Length)
                    {
                        for (long i = 0; i < Buffer.Length; i++)
                        {
                            if (Buffer[i] == Signature[0] | Signature[0] == -1)
                            {
                                for (long j = 0; j < Signature.Length; j++)
                                {
                                    if (Buffer[i + j] == Signature[j] | Signature[j] == -1)
                                    {
                                        Counter++;
                                        if (Counter == Signature.Length)
                                        {
                                            var Result = i + StartAddress;
                                            return Result;
                                        }
                                    }
                                    else
                                    {
                                        Counter = 0;
                                    }
                                }
                            }
                        }
                    }
                    return -1;
                }

            }
            return -1;
        }


        public IntPtr GetBaseAddressByModuleName(string ModuleName)
        {
            GetProcessByName(this.Process.ProcessName);
            foreach (ProcessModule item in Process.Modules)
            {
                if (item.ModuleName == ModuleName)
                    return item.BaseAddress;
            }
            return IntPtr.Zero;
        }
        public IntPtr ReadPointer(IntPtr BaseAddress, int[] offset)
        {
            for (int i = 0; i < offset.Length - 1; i++)
            {
                BaseAddress = (IntPtr)VAM.ReadInt32((IntPtr.Add(BaseAddress, offset[i])));
            }
            return BaseAddress + offset[offset.Length - 1];
        }

    }
}

