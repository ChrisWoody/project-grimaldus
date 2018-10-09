Param (
    [ValidateNotNullOrEmpty()]
    [string] $Username,

    [ValidateNotNullOrEmpty()]
    [string] $Password,

    [ValidateNotNullOrEmpty()]
    [string] $PackagePath
)

$ErrorActionPreference = "Stop"
Set-StrictMode -Version "Latest"

try {
    $zipPath = Get-ChildItem -Path $PackagePath *.zip | Select-Object -first 1
    $PackagePath = Resolve-Path (Join-Path -Path $PackagePath -ChildPath $zipPath)
    
    $msDeployArgs =
    '-verb:sync ' +
    "-source:package='$PackagePath' " + 
    "-dest:ContentPath=.,ComputerName=https://184.173.161.69:8172/MSDeploy.axd?site=chriswoodcodes.net,UserName=$Username,Password=$Password,AuthType='Basic',includeAcls='False' " +
    "-retryAttempts:5 -retryInterval:5000 " +
    "-allowUntrusted"
    
    $commandLine = '&"C:\Program Files\IIS\Microsoft Web Deploy V3\msdeploy.exe" --% ' + $msDeployArgs
    Invoke-Expression $commandLine

    exit 0
}
catch {
    Write-Error $_ -ErrorAction Continue
    exit 1
}
