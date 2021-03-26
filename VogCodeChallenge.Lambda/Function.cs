using System;
using System.IO;
using System.Text;

using Amazon.Lambda.Core;
using Amazon.Lambda.DynamoDBEvents;
using Amazon.DynamoDBv2.Model;
using System.Text.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace VogCodeChallenge.Lambda
{
    public class Function
    {
        public void FunctionHandler(DynamoDBEvent dynamoEvent, ILambdaContext context)
        {
            try
            {
                if (dynamoEvent.Records == null)
                    throw new Exception("Empty record!");

                context.Logger.LogLine($"Beginning to process {dynamoEvent.Records?.Count} records...");

                foreach (var record in dynamoEvent.Records)
                {
                    context.Logger.LogLine($"Event ID: {record.EventID}");
                    context.Logger.LogLine($"Event Name: {record.EventName}");

                    context.Logger.LogLine($"Updated entries");
                    foreach (var itm in record.Dynamodb.Keys)
                    {
                        context.Logger.LogLine($"Entry: {itm.Key}");
                    }
                }

                context.Logger.LogLine("Stream processing complete.");
            }
            catch (Exception ex)
            {
                context.Logger.LogLine(ex.Message);
            }
        }
    }
}