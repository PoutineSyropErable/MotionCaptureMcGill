# Define the path to the DLL
$dllPath = "C:\Users\mocap\Documents\Francois\zzz_ActualProject\C# Motion Capture\Custom\Dnc.dll"

# Load the DLL
$assembly = [System.Reflection.Assembly]::LoadFrom($dllPath)

# List all types in the assembly
$types = $assembly.GetTypes()

foreach ($type in $types) {
    # Find methods in the type
    $methods = $type.GetMethods()

    foreach ($method in $methods) {
        if ($method.Name -eq "AiInputChannel") {
            # Print method information
            $methodInfo = "Method: $($method.Name)`nParameters:"
            foreach ($param in $method.GetParameters()) {
                $methodInfo += "`n  Param: $($param.Name) - $($param.ParameterType)"
            }
            $methodInfo | Out-File -FilePath "C:\Users\mocap\Documents\Francois\zzz_ActualProject\C# Motion Capture\Custom\methodInfo.txt" -Append -Encoding utf8
        }
    }
}

Write-Output "Method information has been written to methodInfo.txt"
