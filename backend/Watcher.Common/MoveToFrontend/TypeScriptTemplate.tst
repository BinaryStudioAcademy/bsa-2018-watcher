${
using System.Text.RegularExpressions;
string ToKebabCase(string typeName, bool type) {
    if(typeName.Contains("Dto")) 
        typeName = typeName.Replace("Dto",""); 
    if(type) 
        typeName = typeName + ".enum"; 
    else 
        typeName = typeName + ".model"; 
    var str=Regex.Replace(typeName, "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])","-$1", RegexOptions.Compiled).Trim().ToLower();
    return str;//.Substring(0, 1).ToLower() + str.Remove(0, 1);
    }

string CleanupName(string propertyName, bool? removeArray = true) {
    if (removeArray.HasValue && removeArray.Value) {
        propertyName = propertyName.Replace("[]",""); }
    return propertyName.Replace("Dto","");
    }

Template(Settings settings) {
    settings.IncludeProject("Watcher.Common").OutputFilenameFactory = (file) => {
        string prefixFolder = "";
        string typeName = "undefined";
        bool type = false;
        if (file.Classes.Count > 0) {       
            typeName = file.Classes.First().Name;// + ".model";
        } else if (file.Interfaces.Count > 0) {
            typeName = file.Interfaces.First().Name;
        } else if (file.Enums.Count > 0) {
            type = true;
            typeName = file.Enums.First().Name;// + ".enum";
        }
        //typeName = typeName.Substring(0, 1).ToLower() + typeName.Remove(0, 1);
        //if(typeName.Contains("Dto")) {
        //   typeName = typeName.Replace("Dto",""); }
        string fileName = prefixFolder + ToKebabCase(typeName, type) + ".ts";             
        return fileName;
        };
    }

string Imports(Class c) => c.Properties
                            .Where(p=>!p.Type.IsPrimitive || p.Type.IsEnum)
                            .Select(p=> $"import {{ {CleanupName(p.Type.Name)} }} from './{ToKebabCase(CleanupName(p.Type.Name), p.Type.IsEnum)}';")
                            .Aggregate("", (all,import) => $"{all}{import}\r\n")
                            .TrimStart();

string TypeRename(Type type) {  
    if(type.Name.Contains("Dto"))
       return type.Name.Replace("Dto","");  
    return type.Name;  
    }

string NameRename(Class parameter) {  
    if(parameter.Name.Contains("Dto"))
        return parameter.Name.Replace("Dto",""); 
    return parameter.Name;  
    } 
  }
$Classes([ExportClassToTypescript])[$Imports
export interface $NameRename $TypeParameters {$Properties[
   $name: $Type[$TypeRename];]
}]

$Enums([ExportEnumToTypescript])[export enum $Name {$Values[
    $Name = $Value][,]
}]

