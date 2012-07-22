[T4Scaffolding.Scaffolder(Description = "Creates a repository")][CmdletBinding()]
param(        
    [parameter(Position = 0, Mandatory = $true, ValueFromPipelineByPropertyName = $true)][string]$ModelType,
    [string]$DbContextType,
	[string]$Area,
    [string]$Project,
    [string]$CodeLanguage,
	[switch]$NoChildItems = $false,
	[string[]]$TemplateFolders,
	[switch]$Force = $false
)

# Ensure you've referenced System.Data.Entity
(Get-Project $Project).Object.References.Add("System.Data.Entity") | Out-Null

$foundModelType = Get-ProjectType $ModelType -Project $Project -BlockUi
if (!$foundModelType) { return }

$primaryKey = Get-PrimaryKey $foundModelType.FullName -Project $Project -ErrorIfNotFound
if (!$primaryKey) { return }

if(!$DbContextType) { $DbContextType = [System.Text.RegularExpressions.Regex]::Replace((Get-Project $Project).Name, "[^a-zA-Z0-9]", "") + "Context" }


# Ensure we can find the DI registration class
$foundDIClassType = Get-ProjectType "Module" -Project $Project
# $propertyName = Get-SingularizedWord $foundModelType.Name
# Add-ClassMemberViaTemplate -Name $propertyName -CodeClass $foundDIClassType -Template RegisterRepositoryToDI -Model @{
# 			EntityType = $foundModelType;
# 			EntityTypeNamePluralized = $foundModelType.Name;
# 		} -SuccessMessage "Register '$propertyName' to DI '$($foundDIClassType.FullName)'" -TemplateFolders $TemplateFolders -Project $Project -CodeLanguage $CodeLanguage

#Add-ClassMember $foundDIClassType "public string MyNewStringField;" -Position 100


$Project=$Project+".BusinessLogic"
		
$outputPath = $foundModelType.Name + "Repository"
if ($Area) {
	$outputPath = Join-Path $Area $outputPath
}
$outputPath = Join-Path "Repositories" $outputPath

if (!$NoChildItems) {
	$dbContextScaffolderResult = Scaffold DbContext -ModelType $ModelType -DbContextType $DbContextType -Area $Area -Project $Project -CodeLanguage $CodeLanguage -BlockUi
	$foundDbContextType = $dbContextScaffolderResult.DbContextType
	if (!$foundDbContextType) { return }
}
if (!$foundDbContextType) { $foundDbContextType = Get-ProjectType $DbContextType -Project $Project }
if (!$foundDbContextType) { return }

$modelTypePluralized = $foundModelType.Name
$defaultNamespace = (Get-Project $Project).Properties.Item("DefaultNamespace").Value
$repositoryNamespace = [T4Scaffolding.Namespaces]::Normalize($defaultNamespace + "." + [System.IO.Path]::GetDirectoryName($outputPath).Replace([System.IO.Path]::DirectorySeparatorChar, "."))
if ($Area) {
	$repositoryNamespace = $repositoryNamespace.Replace("."+$Area,"")
}
$modelTypeNamespace = [T4Scaffolding.Namespaces]::GetNamespace($foundModelType.FullName)

Add-ProjectItemViaTemplate $outputPath -Template Repository -Model @{
	ModelType = [MarshalByRefObject]$foundModelType; 
	PrimaryKey = [string]$primaryKey; 
	DefaultNamespace = $defaultNamespace; 
	RepositoryNamespace = $repositoryNamespace; 
	ModelTypeNamespace = $modelTypeNamespace; 
	ModelTypePluralized = [string]$modelTypePluralized; 
	DbContextNamespace = $foundDbContextType.Namespace.FullName;
	DbContextType = [MarshalByRefObject]$foundDbContextType;
} -SuccessMessage "Added repository '$Project\$outputPath'" -TemplateFolders $TemplateFolders -Project $Project -CodeLanguage $CodeLanguage -Force:$Force

