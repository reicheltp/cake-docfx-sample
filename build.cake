#addin "Cake.DocFx"
#tool "docfx.msbuild"

Task("Default").Does(() => 
{
    var settings = new DocFxSettings {
        WorkingDirectory = "./docs"
    };

    DocFx(settings);
});

RunTarget("Default");