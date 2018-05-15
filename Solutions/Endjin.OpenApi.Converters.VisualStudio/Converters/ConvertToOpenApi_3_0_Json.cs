namespace Endjin.OpenApi.Converters.VisualStudio.Converters
{
    #region Using Directives

    using System;
    using System.Runtime.InteropServices;

    using Endjin.OpenApi.Converters.VisualStudio.CodeGenerators;

    using Microsoft.OpenApi;
    using Microsoft.VisualStudio.Shell;

    using VSLangProj80;

    #endregion 

    /// <summary>
    /// When setting the 'Custom Tool' property of a C#, VB, or J# project item to "ConvertToOpenApi_3_0_Json", 
    /// the GenerateCode function will get called and will return the contents of the generated file to the project system
    /// </summary>
    [ComVisible(true)]
    [Guid("72060E8C-4062-4D19-AA6E-E693CD604652")]
    [ProvideObject(typeof(ConvertToOpenApi_3_0_Json))]
    [CodeGeneratorRegistrationWithFileExtension(typeof(ConvertToOpenApi_3_0_Json), "Convert to OpenAPI 3.0 JSON", "{9A19103F-16F7-4668-BE54-9A1E7A4F7556}", GeneratesDesignTimeSource = true)]
    [CodeGeneratorRegistrationWithFileExtension(typeof(ConvertToOpenApi_3_0_Json), "Convert to OpenAPI 3.0 JSON", vsContextGuids.vsContextGuidVCSProject, GeneratesDesignTimeSource = true)]
    public class ConvertToOpenApi_3_0_Json : BaseCodeGeneratorWithSite
    {
#pragma warning disable 0414
        //The name of this generator (use for 'Custom Tool' property of project item)
        internal static string name = "ConvertToOpenApi_3_0_Json";
#pragma warning restore 0414

        /// <summary>
        /// Function that builds the contents of the generated file based on the contents of the input file
        /// </summary>
        /// <param name="inputFileContent">Content of the input file</param>
        /// <returns>Generated file as a byte array</returns>
        protected override byte[] GenerateCode(string inputFileContent)
        {
            try
            {
                var openApiGenerator = new OpenApiConverter(this.CodeGeneratorProgress);
                return openApiGenerator.ConvertOpenApiDocument(inputFileContent, OpenApiSpecVersion.OpenApi3_0, OpenApiFormat.Json);
            }
            catch (Exception e)
            {
                this.GeneratorError(4, e.ToString(), 1, 1);
                //Returning null signifies that generation has failed
                return null;
            }
        }

        /// <summary>
        /// Set the extension of the generated file (the JSON version of the YAML OpenAPI document)
        /// </summary>
        /// <returns></returns>
        protected override string GetDefaultExtension()
        {
            return ".json";
        }
    }
}