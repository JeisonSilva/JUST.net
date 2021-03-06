﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JUST.NET.Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = File.ReadAllText("Examples/Input.json");

            string transformer = File.ReadAllText("Examples/Transformer_valueof.json"); 
            string transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);


            transformer = File.ReadAllText("Examples/Transformer_valueofarray.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);


            transformer = File.ReadAllText("Examples/Transformer_copy.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_replace.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_delete.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);


            transformer = File.ReadAllText("Examples/Transformer_ifcondition.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_string.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_math.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_aggregate.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_arrayaggregate.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_looping.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_customfunction.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_nestedfunctions.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_xfunctions.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_Existance.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/DataTransformer.xml");
            transformedString = DataTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/DataTransformer.csv");
            transformedString = DataTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer.json");
            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(JObject.Parse(transformer), JObject.Parse(input)));
            Console.WriteLine(transformedString);

           

            Console.WriteLine("################################################################################################");
            string inputJson = File.ReadAllText("Examples/ValidationInput.json");
            string schemaJsonX = File.ReadAllText("Examples/SchemaX.json");
            string schemaJsonY = File.ReadAllText("Examples/SchemaY.json");

            string InputToSplit = File.ReadAllText("Examples/InputToSplit.json");

            List<string> outputs = JsonTransformer.SplitJson(InputToSplit, "$.cars.Ford").ToList<string>();

            foreach (string output in outputs)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine(output);
            }

            Console.WriteLine("################################################################################################");

            JsonValidator validator = new JsonValidator(inputJson);
            validator.AddSchema("x", schemaJsonX);
            validator.AddSchema("y", schemaJsonY);

            validator.Validate();

            Console.WriteLine("################################################################################################");
            transformer = File.ReadAllText("Examples/Transformer_nestedloop.json");
            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(JObject.Parse(transformer), JObject.Parse(input)));
            Console.WriteLine(transformedString);

            Console.WriteLine("################################################################################################");
            transformer = File.ReadAllText("Examples/Transformer_looptests.json");
            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(JObject.Parse(transformer), JObject.Parse(input)));
            Console.WriteLine(transformedString);

            Console.WriteLine("################################################################################################");

            string inputSpecial = File.ReadAllText("Examples/InputSpecial.json");
            transformer = File.ReadAllText("Examples/Transformer_customfunctionspecial.json");
            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(JObject.Parse(transformer), JObject.Parse(inputSpecial)));
            Console.WriteLine(transformedString);

            Console.WriteLine("################################################################################################");

            string inputUnordered = File.ReadAllText("Examples/Input_Unordered.json");
            transformer = File.ReadAllText("Examples/Transform_Unordered.json");
            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(JObject.Parse(transformer), JObject.Parse(inputUnordered)));
            Console.WriteLine(transformedString);

            Console.WriteLine("################################################################################################");

            string inputUnordered2 = File.ReadAllText("Examples/Input_Unordered_2.json");
            transformer = File.ReadAllText("Examples/Transform_Unordered_2.json");
            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(JObject.Parse(transformer), JObject.Parse(inputUnordered2)));
            Console.WriteLine(transformedString);

            Console.WriteLine("################################################################################################");


            string inputDyn= File.ReadAllText("Examples/InputDynamic.json");
            transformer = File.ReadAllText("Examples/TransformDynamic.json");
            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(JObject.Parse(transformer), JObject.Parse(inputDyn)));
            Console.WriteLine(transformedString);

            Console.WriteLine("################################################################################################");

            transformer = File.ReadAllText("Examples/Transformer_externalmethods.json");
            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(JObject.Parse(transformer), JObject.Parse(input)));
            Console.WriteLine(transformedString);

            Console.WriteLine("################################################################################################");

            transformer = File.ReadAllText("Examples/Transformer_array.json");
            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(transformer, input));
            Console.WriteLine(transformedString);

            Console.WriteLine("################################################################################################");

            transformer = File.ReadAllText("Examples/Transformer_array.json");
            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(JArray.Parse(transformer), input));
            Console.WriteLine(transformedString);

            Console.WriteLine("################################################################################################");

            transformer = File.ReadAllText("Examples/Transformer_registeredmethods.json");
            var context = new JUSTContext();
            context.RegisterCustomFunction("ExternalMethods", "ExternalMethods.ExternalClass", "StaticMethod", "External_StaticMethod");
            context.RegisterCustomFunction("ExternalMethods", "ExternalMethods.ExternalClass", "StaticTypedParameters", "External_StaticTypedParameters");
            context.RegisterCustomFunction("ExternalMethods", "ExternalMethods.ExternalClass", "InstanceMethod", "External_InstanceMethod");
            context.RegisterCustomFunction("ExternalMethods", "ExternalMethods.ExternalClass", "TypedParameters", "External_TypedParameters");
            context.RegisterCustomFunction("ExternalMethods", "ExternalMethods.ExternalClass", "NavigateTypedParameters", "External_NavigateTypedParameters");

            context.RegisterCustomFunction(null, "InternalMethods.InternalClass", "StaticMethod");
            context.RegisterCustomFunction(null, "InternalMethods.InternalClass", "StaticTypedParameters");
            context.RegisterCustomFunction(null, "InternalMethods.InternalClass", "InstanceMethod");
            context.RegisterCustomFunction(null, "InternalMethods.InternalClass", "TypedParameters");
            context.RegisterCustomFunction(null, "InternalMethods.InternalClass", "NavigateTypedParameters");

            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(JObject.Parse(transformer), JObject.Parse(input), context));
            Console.WriteLine(transformedString);

            Console.WriteLine("################################################################################################");

            transformer = File.ReadAllText("Examples/Transformer_registeredmethods.json");
            JsonTransformer.GlobalContext.RegisterCustomFunction("ExternalMethods", "ExternalMethods.ExternalClass", "StaticMethod", "External_StaticMethod");
            JsonTransformer.GlobalContext.RegisterCustomFunction("ExternalMethods", "ExternalMethods.ExternalClass", "StaticTypedParameters", "External_StaticTypedParameters");
            JsonTransformer.GlobalContext.RegisterCustomFunction("ExternalMethods", "ExternalMethods.ExternalClass", "InstanceMethod", "External_InstanceMethod");
            JsonTransformer.GlobalContext.RegisterCustomFunction("ExternalMethods", "ExternalMethods.ExternalClass", "TypedParameters", "External_TypedParameters");
            JsonTransformer.GlobalContext.RegisterCustomFunction("ExternalMethods", "ExternalMethods.ExternalClass", "NavigateTypedParameters", "External_NavigateTypedParameters");

            JsonTransformer.GlobalContext.RegisterCustomFunction(null, "InternalMethods.InternalClass", "StaticMethod");
            JsonTransformer.GlobalContext.RegisterCustomFunction(null, "InternalMethods.InternalClass", "StaticTypedParameters");
            JsonTransformer.GlobalContext.RegisterCustomFunction(null, "InternalMethods.InternalClass", "InstanceMethod");
            JsonTransformer.GlobalContext.RegisterCustomFunction(null, "InternalMethods.InternalClass", "TypedParameters");
            JsonTransformer.GlobalContext.RegisterCustomFunction(null, "InternalMethods.InternalClass", "NavigateTypedParameters");

            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(JObject.Parse(transformer), JObject.Parse(input)));
            Console.WriteLine(transformedString);

            Console.WriteLine("################################################################################################");

            JsonTransformer.GlobalContext.EvaluationMode = EvaluationMode.Strict;

            inputDyn = File.ReadAllText("Examples/InputDynamic.json");
            transformer = "{ \"Result\": { \"Header\": \"JsonTransform\", \"#eval(#valueof($.Tree.Flower))\": \"x\", \"#ifgroup(#exists($.Tree.Flower))\": { \"Comment\": { \"Statement\": \"Flower Exists\" } } }}";
            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(JObject.Parse(transformer), JObject.Parse(inputDyn)));
            Console.WriteLine(transformedString);

            Console.WriteLine("################################################################################################");

            JsonTransformer.GlobalContext.EvaluationMode = EvaluationMode.FallbackToDefault;

            inputDyn = File.ReadAllText("Examples/InputDynamic.json");
            transformer = "{ \"Result\": { \"Header\": \"JsonTransform\", \"#ifgroup(1)\": { \"State\": { \"Value1\": \"#valueof($.Tree.Branch)\", \"Value2\": \"#valueof($.Tree.Flower)\" }} } }";

            transformedString = JsonConvert.SerializeObject
                (JsonTransformer.Transform(JObject.Parse(transformer), JObject.Parse(inputDyn)));
            Console.WriteLine(transformedString);

            Console.WriteLine("################################################################################################");

            input = File.ReadAllText("Examples/Input.json");
            transformer = File.ReadAllText("Examples/Transformer_typeconversion.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine(transformedString);

            Console.ReadLine();
        }
    }
}
