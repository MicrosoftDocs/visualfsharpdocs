# Main
$errorActionPreference = 'Stop'

# Step-1: Parse docsets from .openpublishing.publish.config.json
echo "Parse docsets from $publishConfigFile"
$exitCode = 0
$docsets = $publishConfigContent.docsets_to_publish

# Step-2: Download mdproj
echo "Download $mdprojName.mdproj"
$mdprojSource = "$resourceContainerUrl/$packageName/$mdprojName.mdproj"
$mdprojDestination = "$workingDirectory\$mdprojName.mdproj"
$UpdateMdproj = ParseBoolValue("UpdateMdproj") ($UpdateMdproj) ($systemDefaultVariables.Item("UpdateMdproj"))
DownloadFile($mdprojSource) ($mdprojDestination) ($UpdateMdproj)

foreach ($docset in $docsets)
{
    $DocfxConfigFolder = GetValueFromVariableName($docset.build_source_folder) ($docset.build_output_subfolder)
    $DocfxConfigFile = Join-Path $repositoryRoot -ChildPath $DocfxConfigFolder | Join-Path -ChildPath "docfx.json"
    if (!(IsPathExists($DocfxConfigFile)))
    {
        Write-Host "$DocfxConfigFile doesn't exist"
        $exitCode = 1
    }

    # Step-3: run msbuild
    $NeedBuildMdproj = ParseBoolValue("NeedBuildMdproj") ($NeedBuildMdproj) ($systemDefaultVariables.Item("NeedBuildMdproj"))
    if($NeedBuildMdproj)
    {
        echo "Run tool to build md files"
        $Targets = GetValueFromVariableName($Targets) ($systemDefaultVariables.Item("MdprojTargets"))
        $OutputFolder = GetValueFromVariableName($OutputFolder) ($systemDefaultVariables.Item("OutputFolder"))
        $LogOutputFolder = GetValueFromVariableName($LogOutputFolder) ($systemDefaultVariables.Item("LogOutputFolder"))
        $GlobalMetadataFile = GetValueFromVariableName($GlobalMetadataFile) ($systemDefaultVariables.Item("GlobalMetadataFile"))
        $PackageRootFolder = "$packagesDirectory\$packageName.$packageVersion"
        $msbuild = "$Env:SYSTEMROOT\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe"
        & "$msbuild" "$mdprojDestination" /t:$Targets /p:OutputFolder="$OutputFolder" /p:LogOutputFolder="$LogOutputFolder" /p:PackageRootFolder="$PackageRootFolder" /p:DocfxConfigFile="$DocfxConfigFile" /p:GlobalMetadataFile="$GlobalMetadataFile"
        if ($LASTEXITCODE -ne 0)
        {
             $exitCode = $LASTEXITCODE
        }
    }
}

exit $exitCode
