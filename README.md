# OpenAPI.Document.Converters
A Visual Studio 2017 Custom Tool that converts between OpenAPI formats:

- to OpenAPI 2.0 JSON - Set Custom Tool to "ConvertToOpenApi_2_0_Json"
- to OpenAPI 2.0 YAML - Set Custom Tool to "ConvertToOpenApi_2_0_Yaml"
- to OpenAPI 3.0 JSON - Set Custom Tool to "ConvertToOpenApi_3_0_Json"
- to OpenAPI 3.0 YAML - Set Custom Tool to "ConvertToOpenApi_3_0_Yaml"

The primary usage scenario for this tool is the authoring of OpenAPI files in local Azure Function projects.

To add a OpenAPI document to your Function project add the following folder structure

```.azurefunctions\swagger\```

Add a new file called swagger.yaml. On the property pane for this file, set the Custom Tool to equal "ConvertToOpenApi_2_0_Json". This will generate a swagger.json file.

![YAML file property pane in Visual Studio](https://raw.githubusercontent.com/endjin/Endjin.OpenAPI.Converters/master/Assets/yaml-file-property-pane.png)

Finally, select the swagger.json file and in the property pane, set the Build Action to "Content" and the Copy to Output Directory to "Copy if newer".

See the blog post [OpenAPI code generators for Visual Studio](https://blogs.endjin.com/2018/04/openapi-code-generators-for-visual-studio/) by [Howard van Rooijen](https://twitter.com/howardvrooijen) for information about the origins of this project.

## Special Thanks
- [Darrel Miller](https://twitter.com/darrel_miller) for his work on the [OpenAPI.NET SDK](https://github.com/Microsoft/OpenAPI.NET)
- The [TechTalk](http://www.techtalk.at) team as their [SpecFlow.VisualStudio](https://github.com/techtalk/SpecFlow.VisualStudio) project really helped me understand some of the nuances of Visual Studio extensibility.

## Useful Resources

- Have you heard of the [In the Mood for HTTP](https://www.youtube.com/channel/UC5-31Y_XqTe30i-xx1SIUJA) YouTube show by [Darrel Miller](https://twitter.com/darrel_miller) & [Glenn Block](https://twitter.com/gblock)?
- There is also a HTTP APIs Slack channel at http://slack.httpapis.com with discussions on most HTTP related topics such as OpenAPI / Rest / GraphQL etc