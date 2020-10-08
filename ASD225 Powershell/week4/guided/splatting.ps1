# $splat = @{
#     Class = "Win32_SystemEnclosure"
#     Property = "Manufacturer"
#     ErrorAction = "Stop"
# }

# get-wmiobject -computername notMyMachine! @splat


# $splat = @{
    #     Name = "teams-for-linux"
    #     FileVersionInfo = $true
    # }
    
    # Get-Process @splat
    
    
using namespace System.Text
using namespace System.IO

[string]$string = "Hello World"
## Valid values are "SHA1", "SHA256", "SHA384", "SHA512", "MD5"
[string]$algorithm = "SHA256"

[byte[]]$stringbytes = [UnicodeEncoding]::Unicode.GetBytes($string)

[Stream]$memorystream = [MemoryStream]::new($stringbytes)
$hashfromstream = Get-FileHash -InputStream $memorystream `
  -Algorithm $algorithm
$hashfromstream.Hash.ToString()