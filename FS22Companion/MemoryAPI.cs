using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FS22Companion
{
    class MemoryAPI
    {
        public enum NtStatus : uint
        {
            // Success
            Success = 0x00000000,
            Wait0 = 0x00000000,
            Wait1 = 0x00000001,
            Wait2 = 0x00000002,
            Wait3 = 0x00000003,
            Wait63 = 0x0000003f,
            Abandoned = 0x00000080,
            AbandonedWait0 = 0x00000080,
            AbandonedWait1 = 0x00000081,
            AbandonedWait2 = 0x00000082,
            AbandonedWait3 = 0x00000083,
            AbandonedWait63 = 0x000000bf,
            UserApc = 0x000000c0,
            KernelApc = 0x00000100,
            Alerted = 0x00000101,
            Timeout = 0x00000102,
            Pending = 0x00000103,
            Reparse = 0x00000104,
            MoreEntries = 0x00000105,
            NotAllAssigned = 0x00000106,
            SomeNotMapped = 0x00000107,
            OpLockBreakInProgress = 0x00000108,
            VolumeMounted = 0x00000109,
            RxActCommitted = 0x0000010a,
            NotifyCleanup = 0x0000010b,
            NotifyEnumDir = 0x0000010c,
            NoQuotasForAccount = 0x0000010d,
            PrimaryTransportConnectFailed = 0x0000010e,
            PageFaultTransition = 0x00000110,
            PageFaultDemandZero = 0x00000111,
            PageFaultCopyOnWrite = 0x00000112,
            PageFaultGuardPage = 0x00000113,
            PageFaultPagingFile = 0x00000114,
            CrashDump = 0x00000116,
            ReparseObject = 0x00000118,
            NothingToTerminate = 0x00000122,
            ProcessNotInJob = 0x00000123,
            ProcessInJob = 0x00000124,
            ProcessCloned = 0x00000129,
            FileLockedWithOnlyReaders = 0x0000012a,
            FileLockedWithWriters = 0x0000012b,

            // Informational
            Informational = 0x40000000,
            ObjectNameExists = 0x40000000,
            ThreadWasSuspended = 0x40000001,
            WorkingSetLimitRange = 0x40000002,
            ImageNotAtBase = 0x40000003,
            RegistryRecovered = 0x40000009,

            // Warning
            Warning = 0x80000000,
            GuardPageViolation = 0x80000001,
            DatatypeMisalignment = 0x80000002,
            Breakpoint = 0x80000003,
            SingleStep = 0x80000004,
            BufferOverflow = 0x80000005,
            NoMoreFiles = 0x80000006,
            HandlesClosed = 0x8000000a,
            PartialCopy = 0x8000000d,
            DeviceBusy = 0x80000011,
            InvalidEaName = 0x80000013,
            EaListInconsistent = 0x80000014,
            NoMoreEntries = 0x8000001a,
            LongJump = 0x80000026,
            DllMightBeInsecure = 0x8000002b,

            // Error
            Error = 0xc0000000,
            Unsuccessful = 0xc0000001,
            NotImplemented = 0xc0000002,
            InvalidInfoClass = 0xc0000003,
            InfoLengthMismatch = 0xc0000004,
            AccessViolation = 0xc0000005,
            InPageError = 0xc0000006,
            PagefileQuota = 0xc0000007,
            InvalidHandle = 0xc0000008,
            BadInitialStack = 0xc0000009,
            BadInitialPc = 0xc000000a,
            InvalidCid = 0xc000000b,
            TimerNotCanceled = 0xc000000c,
            InvalidParameter = 0xc000000d,
            NoSuchDevice = 0xc000000e,
            NoSuchFile = 0xc000000f,
            InvalidDeviceRequest = 0xc0000010,
            EndOfFile = 0xc0000011,
            WrongVolume = 0xc0000012,
            NoMediaInDevice = 0xc0000013,
            NoMemory = 0xc0000017,
            NotMappedView = 0xc0000019,
            UnableToFreeVm = 0xc000001a,
            UnableToDeleteSection = 0xc000001b,
            IllegalInstruction = 0xc000001d,
            AlreadyCommitted = 0xc0000021,
            AccessDenied = 0xc0000022,
            BufferTooSmall = 0xc0000023,
            ObjectTypeMismatch = 0xc0000024,
            NonContinuableException = 0xc0000025,
            BadStack = 0xc0000028,
            NotLocked = 0xc000002a,
            NotCommitted = 0xc000002d,
            InvalidParameterMix = 0xc0000030,
            ObjectNameInvalid = 0xc0000033,
            ObjectNameNotFound = 0xc0000034,
            ObjectNameCollision = 0xc0000035,
            ObjectPathInvalid = 0xc0000039,
            ObjectPathNotFound = 0xc000003a,
            ObjectPathSyntaxBad = 0xc000003b,
            DataOverrun = 0xc000003c,
            DataLate = 0xc000003d,
            DataError = 0xc000003e,
            CrcError = 0xc000003f,
            SectionTooBig = 0xc0000040,
            PortConnectionRefused = 0xc0000041,
            InvalidPortHandle = 0xc0000042,
            SharingViolation = 0xc0000043,
            QuotaExceeded = 0xc0000044,
            InvalidPageProtection = 0xc0000045,
            MutantNotOwned = 0xc0000046,
            SemaphoreLimitExceeded = 0xc0000047,
            PortAlreadySet = 0xc0000048,
            SectionNotImage = 0xc0000049,
            SuspendCountExceeded = 0xc000004a,
            ThreadIsTerminating = 0xc000004b,
            BadWorkingSetLimit = 0xc000004c,
            IncompatibleFileMap = 0xc000004d,
            SectionProtection = 0xc000004e,
            EasNotSupported = 0xc000004f,
            EaTooLarge = 0xc0000050,
            NonExistentEaEntry = 0xc0000051,
            NoEasOnFile = 0xc0000052,
            EaCorruptError = 0xc0000053,
            FileLockConflict = 0xc0000054,
            LockNotGranted = 0xc0000055,
            DeletePending = 0xc0000056,
            CtlFileNotSupported = 0xc0000057,
            UnknownRevision = 0xc0000058,
            RevisionMismatch = 0xc0000059,
            InvalidOwner = 0xc000005a,
            InvalidPrimaryGroup = 0xc000005b,
            NoImpersonationToken = 0xc000005c,
            CantDisableMandatory = 0xc000005d,
            NoLogonServers = 0xc000005e,
            NoSuchLogonSession = 0xc000005f,
            NoSuchPrivilege = 0xc0000060,
            PrivilegeNotHeld = 0xc0000061,
            InvalidAccountName = 0xc0000062,
            UserExists = 0xc0000063,
            NoSuchUser = 0xc0000064,
            GroupExists = 0xc0000065,
            NoSuchGroup = 0xc0000066,
            MemberInGroup = 0xc0000067,
            MemberNotInGroup = 0xc0000068,
            LastAdmin = 0xc0000069,
            WrongPassword = 0xc000006a,
            IllFormedPassword = 0xc000006b,
            PasswordRestriction = 0xc000006c,
            LogonFailure = 0xc000006d,
            AccountRestriction = 0xc000006e,
            InvalidLogonHours = 0xc000006f,
            InvalidWorkstation = 0xc0000070,
            PasswordExpired = 0xc0000071,
            AccountDisabled = 0xc0000072,
            NoneMapped = 0xc0000073,
            TooManyLuidsRequested = 0xc0000074,
            LuidsExhausted = 0xc0000075,
            InvalidSubAuthority = 0xc0000076,
            InvalidAcl = 0xc0000077,
            InvalidSid = 0xc0000078,
            InvalidSecurityDescr = 0xc0000079,
            ProcedureNotFound = 0xc000007a,
            InvalidImageFormat = 0xc000007b,
            NoToken = 0xc000007c,
            BadInheritanceAcl = 0xc000007d,
            RangeNotLocked = 0xc000007e,
            DiskFull = 0xc000007f,
            ServerDisabled = 0xc0000080,
            ServerNotDisabled = 0xc0000081,
            TooManyGuidsRequested = 0xc0000082,
            GuidsExhausted = 0xc0000083,
            InvalidIdAuthority = 0xc0000084,
            AgentsExhausted = 0xc0000085,
            InvalidVolumeLabel = 0xc0000086,
            SectionNotExtended = 0xc0000087,
            NotMappedData = 0xc0000088,
            ResourceDataNotFound = 0xc0000089,
            ResourceTypeNotFound = 0xc000008a,
            ResourceNameNotFound = 0xc000008b,
            ArrayBoundsExceeded = 0xc000008c,
            FloatDenormalOperand = 0xc000008d,
            FloatDivideByZero = 0xc000008e,
            FloatInexactResult = 0xc000008f,
            FloatInvalidOperation = 0xc0000090,
            FloatOverflow = 0xc0000091,
            FloatStackCheck = 0xc0000092,
            FloatUnderflow = 0xc0000093,
            IntegerDivideByZero = 0xc0000094,
            IntegerOverflow = 0xc0000095,
            PrivilegedInstruction = 0xc0000096,
            TooManyPagingFiles = 0xc0000097,
            FileInvalid = 0xc0000098,
            InstanceNotAvailable = 0xc00000ab,
            PipeNotAvailable = 0xc00000ac,
            InvalidPipeState = 0xc00000ad,
            PipeBusy = 0xc00000ae,
            IllegalFunction = 0xc00000af,
            PipeDisconnected = 0xc00000b0,
            PipeClosing = 0xc00000b1,
            PipeConnected = 0xc00000b2,
            PipeListening = 0xc00000b3,
            InvalidReadMode = 0xc00000b4,
            IoTimeout = 0xc00000b5,
            FileForcedClosed = 0xc00000b6,
            ProfilingNotStarted = 0xc00000b7,
            ProfilingNotStopped = 0xc00000b8,
            NotSameDevice = 0xc00000d4,
            FileRenamed = 0xc00000d5,
            CantWait = 0xc00000d8,
            PipeEmpty = 0xc00000d9,
            CantTerminateSelf = 0xc00000db,
            InternalError = 0xc00000e5,
            InvalidParameter1 = 0xc00000ef,
            InvalidParameter2 = 0xc00000f0,
            InvalidParameter3 = 0xc00000f1,
            InvalidParameter4 = 0xc00000f2,
            InvalidParameter5 = 0xc00000f3,
            InvalidParameter6 = 0xc00000f4,
            InvalidParameter7 = 0xc00000f5,
            InvalidParameter8 = 0xc00000f6,
            InvalidParameter9 = 0xc00000f7,
            InvalidParameter10 = 0xc00000f8,
            InvalidParameter11 = 0xc00000f9,
            InvalidParameter12 = 0xc00000fa,
            MappedFileSizeZero = 0xc000011e,
            TooManyOpenedFiles = 0xc000011f,
            Cancelled = 0xc0000120,
            CannotDelete = 0xc0000121,
            InvalidComputerName = 0xc0000122,
            FileDeleted = 0xc0000123,
            SpecialAccount = 0xc0000124,
            SpecialGroup = 0xc0000125,
            SpecialUser = 0xc0000126,
            MembersPrimaryGroup = 0xc0000127,
            FileClosed = 0xc0000128,
            TooManyThreads = 0xc0000129,
            ThreadNotInProcess = 0xc000012a,
            TokenAlreadyInUse = 0xc000012b,
            PagefileQuotaExceeded = 0xc000012c,
            CommitmentLimit = 0xc000012d,
            InvalidImageLeFormat = 0xc000012e,
            InvalidImageNotMz = 0xc000012f,
            InvalidImageProtect = 0xc0000130,
            InvalidImageWin16 = 0xc0000131,
            LogonServer = 0xc0000132,
            DifferenceAtDc = 0xc0000133,
            SynchronizationRequired = 0xc0000134,
            DllNotFound = 0xc0000135,
            IoPrivilegeFailed = 0xc0000137,
            OrdinalNotFound = 0xc0000138,
            EntryPointNotFound = 0xc0000139,
            ControlCExit = 0xc000013a,
            PortNotSet = 0xc0000353,
            DebuggerInactive = 0xc0000354,
            CallbackBypass = 0xc0000503,
            PortClosed = 0xc0000700,
            MessageLost = 0xc0000701,
            InvalidMessage = 0xc0000702,
            RequestCanceled = 0xc0000703,
            RecursiveDispatch = 0xc0000704,
            LpcReceiveBufferExpected = 0xc0000705,
            LpcInvalidConnectionUsage = 0xc0000706,
            LpcRequestsNotAllowed = 0xc0000707,
            ResourceInUse = 0xc0000708,
            ProcessIsProtected = 0xc0000712,
            VolumeDirty = 0xc0000806,
            FileCheckedOut = 0xc0000901,
            CheckOutRequired = 0xc0000902,
            BadFileType = 0xc0000903,
            FileTooLarge = 0xc0000904,
            FormsAuthRequired = 0xc0000905,
            VirusInfected = 0xc0000906,
            VirusDeleted = 0xc0000907,
            TransactionalConflict = 0xc0190001,
            InvalidTransaction = 0xc0190002,
            TransactionNotActive = 0xc0190003,
            TmInitializationFailed = 0xc0190004,
            RmNotActive = 0xc0190005,
            RmMetadataCorrupt = 0xc0190006,
            TransactionNotJoined = 0xc0190007,
            DirectoryNotRm = 0xc0190008,
            CouldNotResizeLog = 0xc0190009,
            TransactionsUnsupportedRemote = 0xc019000a,
            LogResizeInvalidSize = 0xc019000b,
            RemoteFileVersionMismatch = 0xc019000c,
            CrmProtocolAlreadyExists = 0xc019000f,
            TransactionPropagationFailed = 0xc0190010,
            CrmProtocolNotFound = 0xc0190011,
            TransactionSuperiorExists = 0xc0190012,
            TransactionRequestNotValid = 0xc0190013,
            TransactionNotRequested = 0xc0190014,
            TransactionAlreadyAborted = 0xc0190015,
            TransactionAlreadyCommitted = 0xc0190016,
            TransactionInvalidMarshallBuffer = 0xc0190017,
            CurrentTransactionNotValid = 0xc0190018,
            LogGrowthFailed = 0xc0190019,
            ObjectNoLongerExists = 0xc0190021,
            StreamMiniversionNotFound = 0xc0190022,
            StreamMiniversionNotValid = 0xc0190023,
            MiniversionInaccessibleFromSpecifiedTransaction = 0xc0190024,
            CantOpenMiniversionWithModifyIntent = 0xc0190025,
            CantCreateMoreStreamMiniversions = 0xc0190026,
            HandleNoLongerValid = 0xc0190028,
            NoTxfMetadata = 0xc0190029,
            LogCorruptionDetected = 0xc0190030,
            CantRecoverWithHandleOpen = 0xc0190031,
            RmDisconnected = 0xc0190032,
            EnlistmentNotSuperior = 0xc0190033,
            RecoveryNotNeeded = 0xc0190034,
            RmAlreadyStarted = 0xc0190035,
            FileIdentityNotPersistent = 0xc0190036,
            CantBreakTransactionalDependency = 0xc0190037,
            CantCrossRmBoundary = 0xc0190038,
            TxfDirNotEmpty = 0xc0190039,
            IndoubtTransactionsExist = 0xc019003a,
            TmVolatile = 0xc019003b,
            RollbackTimerExpired = 0xc019003c,
            TxfAttributeCorrupt = 0xc019003d,
            EfsNotAllowedInTransaction = 0xc019003e,
            TransactionalOpenNotAllowed = 0xc019003f,
            TransactedMappingUnsupportedRemote = 0xc0190040,
            TxfMetadataAlreadyPresent = 0xc0190041,
            TransactionScopeCallbacksNotSet = 0xc0190042,
            TransactionRequiredPromotion = 0xc0190043,
            CannotExecuteFileInTransaction = 0xc0190044,
            TransactionsNotFrozen = 0xc0190045,

            MaximumNtStatus = 0xffffffff
        }

        [Flags]
        public enum ProcessAccessType
        {
            PROCESS_TERMINATE = (0x0001),
            PROCESS_CREATE_THREAD = (0x0002),
            PROCESS_SET_SESSIONID = (0x0004),
            PROCESS_VM_OPERATION = (0x0008),
            PROCESS_VM_READ = (0x0010),
            PROCESS_VM_WRITE = (0x0020),
            PROCESS_DUP_HANDLE = (0x0040),
            PROCESS_CREATE_PROCESS = (0x0080),
            PROCESS_SET_QUOTA = (0x0100),
            PROCESS_SET_INFORMATION = (0x0200),
            PROCESS_QUERY_INFORMATION = (0x0400)
        }

        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }


        [Flags]
        public enum AllocType
        {
            Commit = 0x1000,
            Reserve = 0x2000,
            Decommit = 0x4000,
            Free = 0x10000,
            MEM_TOP_DOWN = 0x00100000
        }
        [Flags]
        public enum Protect
        {
            Execute = 0x10,
            ExecuteRead = 0x20,
            ExecuteReadWrite = 0x40,
            ReadOnly = 0x02,
            ReadWrite = 0x04,
            NoAccess = 0x01
        }
        [Flags]
        public enum FreeType
        {
            Decommit = 0x4000,
            Release = 0x8000,
        }

        public struct MEMORY_BASIC_INFORMATION
        {
            public IntPtr BaseAddress;
            public IntPtr AllocationBase;
            public Protect AllocationProtect;
            public IntPtr RegionSize;
            public AllocType State;
            public Protect Protect;
            public FreeType Type;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct SYSTEM_INFO
        {
            internal ushort wProcessorArchitecture;
            internal ushort wReserved;
            internal uint dwPageSize;
            internal IntPtr lpMinimumApplicationAddress;
            internal IntPtr lpMaximumApplicationAddress;
            internal IntPtr dwActiveProcessorMask;
            internal uint dwNumberOfProcessors;
            internal uint dwProcessorType;
            internal uint dwAllocationGranularity;
            internal ushort wProcessorLevel;
            internal ushort wProcessorRevision;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(UInt32 dwDesiredAccess, Int32 bInheritHandle, UInt32 dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern long CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern long ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern long WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern long VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, AllocType flAllocationType, Protect flProtect);
        
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, FreeType dwFreeType);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, int dwSize);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern void GetSystemInfo(ref SYSTEM_INFO Info);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

        [DllImport("kernel32.dll")]
        public static extern uint SuspendThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        public static extern int ResumeThread(IntPtr hThread);

        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern uint NtWriteVirtualMemory(IntPtr ProcessHandle, IntPtr BaseAddress, IntPtr Buffer, UInt32 NumberOfBytesToWrite, ref UInt32 NumberOfBytesWritten);


    }

    public class Memory
    {
        public Memory()
        {
        }

        public Process ReadProcess
        {
            get
            {
                return m_ReadProcess;
            }
            set
            {
                m_ReadProcess = value;
            }
        }
        private Process m_ReadProcess = null;
        private IntPtr m_hProcess = IntPtr.Zero;

        public void Open()
        {
            MemoryAPI.ProcessAccessType access = MemoryAPI.ProcessAccessType.PROCESS_VM_READ
            | MemoryAPI.ProcessAccessType.PROCESS_VM_WRITE
            | MemoryAPI.ProcessAccessType.PROCESS_VM_OPERATION;
            m_hProcess = MemoryAPI.OpenProcess((uint)access, 1, (uint)m_ReadProcess.Id);
        }

        public void CloseHandle()
        {
            long iRetValue;
            iRetValue = MemoryAPI.CloseHandle(m_hProcess);
            if (iRetValue == 0)
                throw new Exception("CloseHandle Failed");
        }

        public byte[] Read(IntPtr MemoryAddress, uint bytesToRead, out int bytesRead)
        {
            byte[] buffer = new byte[bytesToRead];
            IntPtr ptrBytesRead;
            MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, bytesToRead, out ptrBytesRead);
            bytesRead = ptrBytesRead.ToInt32();
            return buffer;
        }

        public byte[] PointerRead(IntPtr MemoryAddress, uint bytesToRead, int[] Offset, out int bytesRead)
        {
            int iPointerCount = Offset.Length - 1;
            IntPtr ptrBytesRead;
            bytesRead = 0;
            byte[] buffer = new byte[4]; //DWORD to hold an Address
            int tempAddress = 0;

            if (iPointerCount == 0)
            {
                MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesRead);
                tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[0]; //Final Address

                buffer = new byte[bytesToRead];
                MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, bytesToRead, out ptrBytesRead);

                bytesRead = ptrBytesRead.ToInt32();
                return buffer;
            }

            for (int i = 0; i <= iPointerCount; i++)
            {
                if (i == iPointerCount)
                {
                    MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesRead);
                    tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i]; //Final Address

                    buffer = new byte[bytesToRead];
                    MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, bytesToRead, out ptrBytesRead);

                    bytesRead = ptrBytesRead.ToInt32();
                    return buffer;
                }
                else if (i == 0)
                {
                    MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesRead);
                    tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[1];
                }
                else
                {
                    MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesRead);
                    tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i];
                }
            }

            return buffer;
        }

        public void Write(IntPtr MemoryAddress, byte[] bytesToWrite, out int bytesWritten)
        {
            IntPtr ptrBytesWritten;
            MemoryAPI.WriteProcessMemory(m_hProcess, MemoryAddress, bytesToWrite, (uint)bytesToWrite.Length, out ptrBytesWritten);
            bytesWritten = ptrBytesWritten.ToInt32();
        }

        public string PointerWrite(IntPtr MemoryAddress, byte[] bytesToWrite, int[] Offset, out int bytesWritten)
        {
            int iPointerCount = Offset.Length - 1;
            IntPtr ptrBytesWritten;
            bytesWritten = 0;
            byte[] buffer = new byte[4]; //DWORD to hold an Address
            int tempAddress = 0;

            if (iPointerCount == 0)
            {
                MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesWritten);
                tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[0]; //Final Address
                MemoryAPI.WriteProcessMemory(m_hProcess, (IntPtr)tempAddress, bytesToWrite, (uint)bytesToWrite.Length, out ptrBytesWritten);

                bytesWritten = ptrBytesWritten.ToInt32();
                return Addr.ToHex(tempAddress);
            }

            for (int i = 0; i <= iPointerCount; i++)
            {
                if (i == iPointerCount)
                {
                    MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesWritten);
                    tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i]; //Final Address
                    MemoryAPI.WriteProcessMemory(m_hProcess, (IntPtr)tempAddress, bytesToWrite, (uint)bytesToWrite.Length, out ptrBytesWritten);

                    bytesWritten = ptrBytesWritten.ToInt32();
                    return Addr.ToHex(tempAddress);
                }
                else if (i == 0)
                {
                    MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesWritten);
                    tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i];
                }
                else
                {
                    MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesWritten);
                    tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i];
                }
            }

            return Addr.ToHex(tempAddress);
        }

        public int PID()
        {
            return m_ReadProcess.Id;
        }

        public void SuspendProcess()
        {
            var process = m_ReadProcess;

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = MemoryAPI.OpenThread(MemoryAPI.ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                MemoryAPI.SuspendThread(pOpenThread);

                MemoryAPI.CloseHandle(pOpenThread);
            }
        }

        public void ResumeProcess()
        {
            var process = m_ReadProcess;

            if (process.ProcessName == string.Empty)
                return;

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = MemoryAPI.OpenThread(MemoryAPI.ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                var suspendCount = 0;
                do
                {
                    suspendCount = MemoryAPI.ResumeThread(pOpenThread);
                } while (suspendCount > 0);

                MemoryAPI.CloseHandle(pOpenThread);
            }
        }

        public string BaseAddressH()
        {
            return Addr.ToHex(m_ReadProcess.MainModule.BaseAddress.ToInt32());
        }

        public int BaseAddressD()
        {
            return m_ReadProcess.MainModule.BaseAddress.ToInt32();
        }

        public void Alloc(out long Addr, int Size)
        {
            Addr = MemoryAPI.VirtualAllocEx(m_hProcess, IntPtr.Zero, Size, MemoryAPI.AllocType.Commit, MemoryAPI.Protect.ExecuteReadWrite);
        }

        public void AllocNearAddr(out long Address, int Size, long nearAddr)
        {
            //MemoryAPI.SYSTEM_INFO SI = new MemoryAPI.SYSTEM_INFO();
            //MemoryAPI.GetSystemInfo(ref SI);
            long maxAddress = nearAddr + 0x7FFF0000;
            long currentAddress = nearAddr - 0x7FFF0000;

            MemoryAPI.MEMORY_BASIC_INFORMATION mem_basic_info = new MemoryAPI.MEMORY_BASIC_INFORMATION();

            while (currentAddress < maxAddress)
            {
                MemoryAPI.VirtualQueryEx(m_hProcess, (IntPtr)currentAddress, out mem_basic_info, Marshal.SizeOf(typeof(MemoryAPI.MEMORY_BASIC_INFORMATION)));
                string addressStr = currentAddress.ToString("X");
                if(addressStr.Length > 3)
                {
                    if (mem_basic_info.State == MemoryAPI.AllocType.Free && addressStr.Substring(addressStr.Length - 3) == "000")
                    {
                        //MessageBox.Show(currentAddress.ToString("X"));
                        currentAddress = Addr.RoundToNearest64KMultiple(currentAddress);
                        // We now need to check if the resulting address is free or not
                        MemoryAPI.VirtualQueryEx(m_hProcess, (IntPtr)currentAddress, out mem_basic_info, Marshal.SizeOf(typeof(MemoryAPI.MEMORY_BASIC_INFORMATION)));
                        if(mem_basic_info.State == MemoryAPI.AllocType.Free)
                            break;
                    }
                }
                currentAddress = (long)mem_basic_info.BaseAddress + (long)mem_basic_info.RegionSize;
            }

            //MessageBox.Show(currentAddress.ToString("X"));

            Address = MemoryAPI.VirtualAllocEx(m_hProcess, (IntPtr)currentAddress, Size, MemoryAPI.AllocType.Commit /*| MemoryAPI.AllocType.Reserve*/, MemoryAPI.Protect.ExecuteReadWrite);

            //MessageBox.Show(Address.ToString("X"));
        }

        public bool Dealloc(long Addr)
        {
            var success = MemoryAPI.VirtualFreeEx(m_hProcess, (IntPtr)Addr, 0, MemoryAPI.FreeType.Release);
            return success;
        }
    }

    public static class Addr
    {
        public static string Make(byte[] buffer)
        {
            string sTemp = "";

            for (int i = 0; i < buffer.Length; i++)
            {
                if (Convert.ToInt16(buffer[i]) < 10)
                    sTemp = "0" + ToHex(buffer[i]) + sTemp;
                else
                    sTemp = ToHex(buffer[i]) + sTemp;
            }

            return sTemp;
        }

        public static string ToHex(long Decimal)
        {
            return Decimal.ToString("X"); //Convert Decimal to Hexadecimal
        }

        public static int ToDec(string Hex)
        {
            return int.Parse(Hex, NumberStyles.HexNumber); //Convert Hexadecimal to Decimal
        }

        public static long RoundToNearest64KMultiple(long n)
        {
            // Smaller multiple
            long a = (n / 0x10000) * 0x10000;

            // Larger multiple
            long b = a + 0x10000;

            // Return the largest, because we need it to be free memory
            return b;
        }
    }
}
