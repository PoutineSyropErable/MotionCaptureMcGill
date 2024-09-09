# Define the path to the DLL and the output file
$dllPath = "C:\Users\mocap\Documents\Francois\zzz_ActualProject\C# Motion Capture\Custom\Dnc.dll"
$outputFile = "C:\Users\mocap\Documents\Francois\zzz_ActualProject\C# Motion Capture\Custom\methods.txt"

# Load the DLL
$assembly = [System.Reflection.Assembly]::LoadFrom($dllPath)

# Initialize the output file
"Types and Methods in $dllPath`n" | Out-File -FilePath $outputFile -Encoding utf8

# List all types in the assembly
$types = $assembly.GetTypes()

foreach ($type in $types) {
    $typeName = "Type: $($type.FullName)"
    $typeName | Out-File -FilePath $outputFile -Append -Encoding utf8
    
    # List methods for each type
    $methods = $type.GetMethods()
    foreach ($method in $methods) {
        $methodName = "  Method: $($method.Name)"
        $methodName | Out-File -FilePath $outputFile -Append -Encoding utf8
    }
}

Write-Output "Methods have been written to $outputFile"
