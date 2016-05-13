# Main
$errorActionPreference = 'Stop'

$mdprojBuilderScript = "mdproj.builder.ps1"
$entryPointSource = "$resourceContainerUrl/$packageName/$mdprojBuilderScript"
$entryPointDestination = "$workingDirectory\$mdprojBuilderScript"
DownloadFile($entryPointSource) ($entryPointDestination) ($true)

$mdprojName = ".openpublishing.build"
& "$workingDirectory\mdproj.builder.ps1"
exit $LASTEXITCODE