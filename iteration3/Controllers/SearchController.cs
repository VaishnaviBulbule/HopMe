using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using iteration3.Models;

using SendGrid;
using SendGrid.Helpers.Mail;


//using Syncfusion.Pdf;
//using Syncfusion.Pdf.Graphics;
//using System.Drawing;


namespace Iteration_2.Controllers
{
    public class SearchController : Controller
    {
        
        webModel ds = new webModel();
      
        // Get options from data table for users
        public ActionResult Analysis()
        {
            //ViewBag.age = new SelectList(ds.agegroup, "Id", "ageGroup1");
            //ViewBag.gender = new SelectList(ds.gender, "Id", "gender1");
            ViewBag.English_Profeciency = new SelectList(ds.English_Profeciency, "Id", "degree", "value");
            ViewBag.education = new SelectList(ds.Highest_education, "Id", "degree", "value");
            ViewBag.field_study = new SelectList(ds.filed_study, "Id", "degree", "value");
            return View();
        }



        public ActionResult Articles()
        {
            return View();
        }
        public ActionResult quizz()
        {
            return View();
        }
        public ActionResult Email()
        {

            return View();
        }
        public ActionResult Result()
        {

            return View();
        }

        
        public ActionResult Jobs(String prediction)
        {

            ViewBag.prediction = prediction;
            return View();
        }
        [HttpPost]

        // Get selection from users, then match value based on database, pass value to result page.
        public ActionResult Result(FormCollection Fc)

        {
            int educationID;
            int highest_education;
            if (int.TryParse(Fc["education"], out highest_education))
            {
                educationID = int.Parse(Fc["education"]);
                foreach (var x in ds.Highest_education)
                {
                    if (x.id == educationID)
                    {
                        highest_education = x.value;
                    }
                }
            }
            else
            {
              return RedirectToAction("Analysis", "Search");

            }

            int fieldStudyID;
           
            if (int.TryParse(Fc["field_study"], out fieldStudyID))
            {
                fieldStudyID = int.Parse(Fc["field_study"]);
            }
            else
            {
                return RedirectToAction("Analysis", "Search");

            }

            int englishID;
            if (int.TryParse(Fc["English_Profeciency"], out englishID))
            {
                englishID = int.Parse(Fc["English_Profeciency"]);
              
            }
            else
            {
                return RedirectToAction("Analysis", "Search");
            }

            foreach (var y in ds.prediction)
            {
                if ( y.english_proficiency == englishID && y.highest_education == highest_education && y.field_of_study== fieldStudyID)
                {
                    ViewBag.pred1 = y.pred_1;
                    ViewBag.pred2 = y.pred_2;
                    ViewBag.pred3 = y.pred_3;

                    // diploma or higher and NATURAL AND PHYSICAL SCIENCES
                    if (highest_education >= 7 && y.field_of_study == 1)
                    {
                        ViewBag.pred1 = "Meteorologist";
                        ViewBag.pred2 = "Exercise Physiologist";
                    } // INFORMATION TECHNOLOGY
                    else if(highest_education >= 7 && y.field_of_study == 2)
                    {
                        ViewBag.pred1 = "Web Developer";
                        ViewBag.pred2 = "Data Center Technician";
                    } // ENGINEERING AND RELATED TECHNOLOGIES
                    else if(highest_education >= 7 && y.field_of_study == 3)
                    {
                        ViewBag.pred1 = "Cyber Security Consultant";
                        ViewBag.pred2 = "Data Center Technician";
                    } // ARCHITECTURE AND BUILDING
                    else if(highest_education >= 7 && y.field_of_study == 4)
                    {
                        ViewBag.pred1 = "Architectural Draftsperson";
                        ViewBag.pred2 = "Junior Design Engineer";
                    } // AGRICULTURE, ENVIRONMENTAL AND RELATED STUDIES
                    else if (highest_education >= 7 && y.field_of_study == 5)
                    {
                        ViewBag.pred1 = "Bio Technician";
                        ViewBag.pred2 = "Environmental Cadet";
                    } // HEALTH
                    else if (highest_education >= 7 && y.field_of_study == 6)
                    {
                        ViewBag.pred1 = "Personal Care Assistants (PCA)";
                        ViewBag.pred2 = "Aged Care Workers";
                    } // MANAGEMENT AND COMMERCE
                    else if (highest_education >= 7 && y.field_of_study == 8)
                    {
                        ViewBag.pred1 = "Sales Consultant";
                        ViewBag.pred2 = "Business Support Officer";
                    } // SOCIETY AND CULTURE
                    else if (highest_education >= 7 && y.field_of_study == 9)
                    {
                        ViewBag.pred1 = "Child Protection Practitioner";
                    } // CREATIVE ARTS
                    else if (highest_education >= 7 && y.field_of_study == 10)
                    {
                        ViewBag.pred1 = "Trainee Arts";
                    } // FOOD, HOSPITALITY AND PERSONAL SERVICES
                    else if (highest_education >= 7 && y.field_of_study == 11)
                    {
                        ViewBag.pred1 = "Food Services Officer";
                        ViewBag.pred2 = "Technical Assistant";
                    }

                }

            }
        
            return View();
        }
      
       




        // Pass the 3 predictions and email address to sendgrid api.
        public void CallEmail(string prediction1, string prediction2, string prediction3,
            string email)
        {
            Execute(prediction1, prediction2, prediction3, email).Wait();

        }

        //The content of email 
        static async Task Execute(string prediction1, string prediction2, string prediction3,string email)
        {
            //The below code is using the sendgrid API to send an e-mail. Code is taken from the sendgrid website.
            String UNIQUE_KEY = "";
            var client = new SendGridClient(UNIQUE_KEY);
            var from = new EmailAddress("hopmekiwiprod@gmail.com", "HopMe-by Kiwiprod Analysis result");
            var to = new EmailAddress(email, "");
            var plainTextContent = "HopMe-by Kiwiprod Analysis result"; //use your prediction strings here to form the template
            var htmlContent =
            "<p>" + "hopMe-kiwiprod <br><br> Hello! Your result is ready based on our Employability Solution. <br> <br> Areas you will most likely be employed in:<br>"
                + "Prediction 1- " + prediction1 + "<br>" + "Prediction 2- " + prediction2 + "<br>" + "Prediction 3- " + prediction3 +
                 "<br> <br>" +
                "Read related articles:https://https://hopme-kiwiprod.ml/Search/Articles" + "<br><br>" + "Thank you for trying out our AI model. <br> <br> hopMe truly wishes you" +
                "all the best with your career journey!<br><br>" + "Best Regards,<br>Kiwiprod<br>" +
                "</p>";

            var msg = MailHelper.CreateSingleEmail(from, to, "Your Predictions!", plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg).ConfigureAwait(false);

        }


    }
}