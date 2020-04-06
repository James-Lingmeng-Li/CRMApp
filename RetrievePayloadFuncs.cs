using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;


namespace CRMApp

{
    public static class RetrievePayloadFuncs
    {
        //In-memory Database
        static List<ApplicationDatabase> items = new List<ApplicationDatabase>();

        //Create new application function
        [FunctionName("CreateApplication")]

        //Get request body
        public static async Task<IActionResult> CreateApplication(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "crm/application")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Creating a new application list item.");

            //Get request body
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

            var input = JsonConvert.DeserializeObject<ApplicationCreateModel>(requestBody);

            //Check the input data
            if (input == null)
            {
                return new BadRequestObjectResult("Bad input, please try again!");
            }

            //Data Mapping
            var data = new ApplicationDatabase()
            {
                application_id = input.application_id,
                applicant = input.applicant,
                __v = input.__v,
                applicationType = input.applicationType
            };
            items.Add(data);
            return new OkObjectResult(data);
        }

        //Show all applications function
        [FunctionName("GetAllApplication")]
        public static IActionResult GetAllApplication(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "crm/application")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Getting application list items.");

            return new OkObjectResult(items);
        }


        //Show applicaiton content by Id function
        [FunctionName("GetApplicationById")]
        public static IActionResult GetApplicationById(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "crm/application/{id}")] HttpRequest req,
            ILogger log, string id)
        {
            var applicaitonById = items.FirstOrDefault(t => t.Id == id);
            if (applicaitonById == null)
            {
                return new BadRequestObjectResult("Application not found, please check your input!");
            }
            return new OkObjectResult(applicaitonById);
        }


        //Update application content by Id function
        [FunctionName("UpdateApplicationById")]
        public static async Task<IActionResult> UpdateApplicationById(
            [HttpTrigger(AuthorizationLevel.Function, "put", Route = "crm/application/{id}")] HttpRequest req,
            ILogger log, string id)
        {
            var applicaitonById = items.FirstOrDefault(t => t.Id == id);
            if (applicaitonById == null)
            {
                return new BadRequestObjectResult("Application not found, please check your input!");
            }

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var updated = JsonConvert.DeserializeObject<ApplicationUpdateModel>(requestBody);
            if (!string.IsNullOrEmpty(updated.application_id))
            {
                applicaitonById.application_id = updated.application_id;
                applicaitonById.applicant = updated.applicant;
                applicaitonById.__v = updated.__v;
                applicaitonById.applicationType = updated.applicationType;
            };
            return new OkObjectResult(applicaitonById);
        }



        //Delete application by Id function
        [FunctionName("DeleteApplicationById")]
        public static IActionResult DeleteApplicationById(
            [HttpTrigger(AuthorizationLevel.Function, "delete", Route = "crm/application/{id}")] HttpRequest req,
            ILogger log, string id)
        {
            var applicaitonById = items.FirstOrDefault(t => t.Id == id);
            if (applicaitonById == null)
            {
                return new BadRequestObjectResult("Application not found, please check your input!");
            }
            items.Remove(applicaitonById);
            return new OkResult();
        }

    }
}
