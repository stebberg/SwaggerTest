namespace SwaggerTest
{
    using Namotion.Reflection;
    using NJsonSchema;
    using NJsonSchema.Generation;
    using System.Runtime.Serialization;

    namespace test
    {
        public class InheritanceSchemaProcessor : ISchemaProcessor
        {
            public void Process(SchemaProcessorContext context)
            {
                if (context.Type.Name is nameof(Err))
                {
                    var attributes = context.Type.GetCustomAttributes(typeof(KnownTypeAttribute), true) as Attribute[];
                    foreach (Attribute attribute in attributes)
                    {
                        var knownTypeAttribute = (KnownTypeAttribute)attribute;
                        var schema = context.Generator.GenerateWithReference<JsonSchema>(knownTypeAttribute.Type.ToContextualType(), context.Resolver);
                        context.Schema.AnyOf.Add(schema);
                    }
                    context.Schema.Properties.Clear();
                    context.Schema.AllowAdditionalProperties = true;
                }
            }
        }
    }

}
