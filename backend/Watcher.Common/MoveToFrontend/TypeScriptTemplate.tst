${
Template(Settings settings)
    {
        settings.IncludeProject("Watcher.Common").OutputFilenameFactory = (file) => {
                string prefixFolder = "";
                string typeName = "undefined";
                if (file.Classes.Count > 0) {
                    typeName = file.Classes.First().Name;
                } else if (file.Interfaces.Count > 0) {
                    typeName = file.Interfaces.First().Name;
                } else if (file.Enums.Count > 0) {
                    typeName = file.Enums.First().Name;
                }
                typeName = typeName.Substring(0, 1).ToLower() + typeName.Remove(0, 1);
                string fileName = prefixFolder + typeName + ".ts";             
                return fileName;
            };
    }
  }
$Classes([ExportClassToTypescript])[ 
    export interface $Name$TypeParameters { $Properties[
        $name: $Type;]
    }]

$Enums([ExportEnumToTypescript])[enum $Name {
    $Values[
    $Name = $Value][,]
}]

