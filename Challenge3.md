<h1>AI Tech Series – Hackathon</h1>
<h1>Challenge 3 – Face Registration, Verification & Audit Log</h1>
<p>In this Challenge 3, you have to use Azure Face Register API, Azure Face Verify API and should handle the Audit log of the whole application.</p>
<h2>Getting Started</h2>
<h3>Prerequisites</h3>
<li>Kindly ensure that the application works fine so far.</li>
<h3>Code Summary</h3>
<p>For the Face Registration, you should use three Azure face APIs [<b>Create Person API</b>, <b>Add Face API</b> and <b>Train API</b>]. For the Face Verification, you should use two Azure Face APIs [<b>Detect API</b> and <b>Identify API</b>]. In the Admin portal, have to display all the audit logs in the Audit Log page.</p>
<p>Create the Face registration and Face verification under <b>User</b> part, where as Audit Log under <b>Admin</b> part</p>
<h3>Create Group ID</h3>
  <ol>
    <strong>
      <li>Follow the below steps and create the group id</li>
      <li>Navigate to <a href="https://southeastasia.dev.cognitive.microsoft.com/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395244">Developer Portal</a>, click on 'PersonGroup' tab on the left pane</li>&nbsp;
      <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_group_id/face_1.jpg" alt="image" style="max-width: 100%;">&nbsp;
      <li>Click on 'Create' tab on the left pane</li>&nb
      sp;
      <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_group_id/face_2.jpg" alt="image" style="max-width: 100%;">&nbsp;
      <li>Select the region</li>&nbsp;
      <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_group_id/face_3.jpg" alt="image" style="max-width: 100%;">&nbsp;
      <li>Enter any id in PersonGroupId, specify the face api key created in Azure portal here in 'Ocp-Apim-Subscription-Key' [Note : use the face api key that you have created in Challenge 1]</li>&nbsp;
      <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_group_id/face_4.jpg" alt="image" style="max-width: 100%;">&nbsp;
      <li>In the Json specify the name and recognitionModel [Note : recognitionModel value must be 'recognition_01']</li>&nbsp;
      <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_group_id/face_5.jpg" alt="image" style="max-width: 100%;">&nbsp;
      <li>Response will be displayed</li>&nbsp;
      <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_group_id/face_6.jpg" alt="image" style="max-width: 100%;">&nbsp;
      <li>Note down your group id to use it on your code later</li>&nbsp;
  </strong>
</ol>
<h3>Objective : Call the Image Validation function</h3>
<h3>Psuedo Code : </h3>
<p><b>STEP 1 : </b>The user should be able to take a snapshot from the livestream or to be able to select a local image [Provide both the options]</p>
<p><b>STEP 1 : </b>Call the <b>Image Validation</b> function which you have created in the Challenge 1 to validate the image given by the user</p>
<p><b>STEP 2 : </b>You have to call the Face registration API Only when the four attributes specified in the <b>Image Validation function</b> are succedded</p>
<h3>Objective : Invoke the Register API</h3>
<h3>Psuedo Code : </h3>
<p><b>STEP 1 : </b>Using Azure Face API you have to do the Face registration</p>
<p><b>STEP 2 : </b>Create a function, in which you have to call three Azure Face APIs for registering the face in Azure</p>
<p><b>STEP 3 : </b>First call the <b>Create Person API</b> and get the <b>Person ID</b> from the json response</p>
<p><b>STEP 4 : </b>To call the <b>Create Person API</b> you need the <b>Create Person API</b> Endpoint, Face API Key, Group ID and Person Name [you can give any name for the person name]</p>
<p><b>STEP 5 : </b>Now you have to call the <b>Add Face API</b></p>
<p><b>STEP 6 : </b>To call the <b>Add Face API</b> you need the Person ID [(i.e) <b>Create Person API</b>'s response]</p>
<p><b>STEP 7 : </b>Finally call the <b>Train API</b> and get the success response</p>
<p><b>STEP 8 : </b>To call the <b>Train API</b> you need the Group ID and Face API Key</p>
<h3>Objective : Call the gesture randomly</h3>
<h3>Psuedo Code : </h3>
<p><b>STEP 1 : </b>There will be already five gestures in the <b>gesture</b> table, create a function for which you have to call any one of the gesture randomly from the table and display it in the front end</p>
<p><b>STEP 2 : </b>The user has to show the gesture (which you are displaying randomly) in front of the camera, you have to call the Azure's Custom Vision API</p>
<h3>Objective : Invoke the Verify API</h3>
<h3>Psuedo Code : </h3>
<p><b>STEP 1 : </b>Using Azure Face API you have to do the Face verification</p>
<p><b>STEP 2 : </b>Create a function, in which you have to call two Azure Face APIs for verifying the face</p>
<p><b>STEP 3 : </b>First call the <b>Create Person API</b> and get the <b>Person ID</b> from the json response</p>
<p><b>STEP 4 : </b>To call the <b>Create Person API</b> you need the <b>Create Person API</b> Endpoint, Face API Key, Group ID and Person Name [you can give any name for the person name]</p>
<p><b>STEP 5 : </b>Now you have to call the <b>Add Face API</b></p>
<p><b>STEP 6 : </b>To call the <b>Add Face API</b> you need the Person ID [(i.e) <b>Create Person API</b>'s response]</p>
<p><b>STEP 7 : </b>Finally call the <b>Train API</b> and get the success response</p>
<p><b>STEP 8 : </b>To call the <b>Train API</b> you need the Group ID and Face API Key</p>
<h3></h3>
    public string VerifyFace(byte[] imageBytes,bool CheckIn)
    {
        try
        {
            string faceid = DetectFace(imageBytes);
            if (faceid == "")
                return "Face Not Found";
            else
            {
                string personid = IdentifyFace(faceid);
                if (personid == "")
                    return "Unauthorized Person";
                else
                {
                    DateTime dt = DateTime.Now;
                    string date = dt.ToString("dd/MM/yyyy"); // Will give you smth like 25/05/2011
                    string time = dt.ToString("hh:mm tt"); //Output: 11:00 PM
                    VerifyTimeTable vtt = new VerifyTimeTable();
                    string name = GetPersonInfo(personid);
                    if (CheckIn)
                    {
                         if (vtt.CheckIn(personid, date, time))
                            return "Welcome " + name + ", You Checked-In at " + time;
                        else
                            return "Sorry " + name + ", You are Already Checked-In";
                    }
                    else
                    {
                        if (vtt.CheckOut(personid, date, time))
                            return "Good Bye " + name + ", You Checked-Out at " + time;
                        else
                            return "Please Check-In " + name;
                    }
                }
            }
&nbsp;
        }
        catch (Exception e)
        {
            error = e.Message;
            return "";
        }
    }
    private string DetectFace(byte[] imageBytes)
    {
        try
        {
&nbsp;
            var client = new RestClient(FaceIDEndpoint + "/face/v1.0/detect?returnFaceId=true&returnFaceLandmarks=false&recognitionModel=recognition_01&returnRecognitionModel=false");
            var request = new RestRequest(Method.POST);
&nbsp;
            request.AddParameter("undefined", imageBytes, ParameterType.RequestBody);
            request.AddHeader("ocp-apim-subscription-key", subscriptionKey);
            request.AddHeader("content-type", "application/octet-stream");
&nbsp;
            IRestResponse response = client.Execute(request);
            JArray PersonArray = JArray.Parse(response.Content);
&nbsp;
            string faceId = "";
            for (int i = 0; i < PersonArray.Count; i++)
            {
                dynamic PersonData = JObject.Parse(PersonArray[i].ToString());
                faceId = PersonData.faceId;
                i = PersonArray.Count;
            }
            return faceId;
        }
        catch (Exception)
        {
            return "";
        }
    }
&nbsp;
    private string IdentifyFace(string FaceID)
    {
        try
        {
            var client = new RestClient(FaceIDEndpoint + "/face/v1.0/identify");
            var request = new RestRequest(Method.POST);
&nbsp;
            request.AddHeader("ocp-apim-subscription-key", subscriptionKey);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\r\n    \"personGroupId\": \"" + PersonGroupId + "\",\r\n    \"faceIds\": [\r\n        \"" + FaceID + "\"\r\n    ],\r\n    \"maxNumOfCandidatesReturned\": 1,\r\n    \"confidenceThreshold\": 0.5\r\n}", ParameterType.RequestBody);
&nbsp;
            IRestResponse response = client.Execute(request);
            JArray ResponseArray = JArray.Parse(response.Content);
&nbsp;
            string personid = "";
            for (int i = 0; i < ResponseArray.Count; i++)
            {
                dynamic PersonData = JObject.Parse(ResponseArray[i].ToString());
                JArray PersonArray = JArray.Parse(PersonData.candidates.ToString());
                for (int j = 0; j < PersonArray.Count; j++)
                {
                    dynamic Person = JObject.Parse(PersonArray[j].ToString());
                    personid = Person.personId;
                    j = PersonArray.Count;
                }
                i = ResponseArray.Count;
            }
            return personid;
        }
        catch (Exception)
        {
            return "";
        }
    }
&nbsp;
    private string GetPersonInfo(string personId)
    {
        try
        {
            var client = new RestClient(FaceIDEndpoint + "/face/v1.0/persongroups/" + PersonGroupId + "/persons/" + personId);
            var request = new RestRequest(Method.GET);
&nbsp;
            request.AddHeader("ocp-apim-subscription-key", subscriptionKey);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
&nbsp;
            dynamic PersonData = JObject.Parse(response.Content);
            return PersonData.name;
        }
        catch (Exception)
        {
            return "";
        }
    }
}
                </code>
            </pre>
        </blockquote>
    </strong>
<p>To save the details of a User in the database, follow the code below.</p>
  <strong>
    <li>Paste the code given below in 'StorageHandler.cs', (i.e) below the comment 'Paste the 'FaceRegistrationUserTable' Class code here...'</li>
    <blockquote>
        <pre>
           <code>
public class FaceRegistrationUserTable
{
    //Connection String
    private static string connectionString = ConfigurationManager.AppSettings["AzureSqlConnectionString"];
    public string error = "";
&nbsp;
    public bool Add(string name, string phone, string gender, string email, string faceid)
    {
&nbsp;
        try
        {
            // Initialization 
            SqlConnection conn;
            SqlCommand cmd;
&nbsp;
            using (conn = new SqlConnection(connectionString))
            {
                // Selecting the perticular row in the table and updating that using particular ID 
                cmd = new SqlCommand("INSERT INTO usertable(name, Phone, gender, email, faceid) VALUES('" + name + "','" + phone + "','" + gender + "','" + email + "','" + faceid + "')", conn);
                //connection open
                conn.Open();
                var temp = cmd.ExecuteNonQuery();
                //connection close
                conn.Close();
                if (temp != 0)
                    return true;
                return false;
            }
        }
        catch (Exception e)
        {
            error = e.Message;
            // Returning the result
            return false;
        }
    }
}
            </code>
        </pre>
   </blockquote></strong></ol>
<h3>Invoke the FaceRegistrationHandler Class from Facade</h3>
<ol>
<strong>
<li>Paste the code given below in 'Facade.cs', (i.e) below the comment 'Paste the 'User_Registration' Function Code here...'</li>
<blockquote>
 <pre>
   <code>
public static List&lt;List&lt;string&gt;&gt; User_Registration(string name, string gender, string phone, string email, byte[] ImageUrl)
{
    FaceRegistrationHandler fc_obj = new FaceRegistrationHandler();
    FaceRegistrationUserTable frt = new FaceRegistrationUserTable();
    List&lt;List&lt;string&gt;&gt; err = new List&lt;List&lt;string&gt;&gt;();
    err.Add(new List&lt;string&gt;());
    string faceid = fc_obj.RegisterFace(ImageUrl, name);
    if (faceid != "")
    {
        frt.Add(name, gender, phone, email, faceid);
        err[0].Add("Registered Successfully");
        err[0].Add("");
        return err;
    }
    else
    {
        if (fc_obj.error != "")
        {
            err[0].Add("Face Not Found");
            err[0].Add("");
            return err;
        }
        err[0].Add("Face Not Found");
        err[0].Add("");
        return err;
    }
}
   </code>
</pre>
</blockquote>
</strong>
<strong>
    <li>Replace the whole code of User_ImageValidation() in Facade.cs</li>
        <blockquote>
            <pre>
                <code>
public static List&lt;List&lt;string&gt;&gt; User_ImageValidation(string realfakecheck,byte[] imagebyte,string url)
{
            List&lt;List&lt;string&gt;&gt; err = new List&lt;List&lt;string&gt;&gt;();
            err.Add(new List&lt;string&gt;());
&nbsp;
            ImageValidationHandler ivhobj = new ImageValidationHandler();
&nbsp;
            ImageValidationTable ivtobj = new ImageValidationTable();
&nbsp;
            GestureHandler gsobj = new GestureHandler();
&nbsp;
            FaceRegistrationHandler fcobj = new FaceRegistrationHandler();
&nbsp;
            List&lt;bool&gt; flag = ivtobj.UserList();
            if (ivtobj.error != "")
            {
                err[0].Add("");
                err[0].Add(ivtobj.error);
                return err;
            }
&nbsp;
            string result = ivhobj.Validate(url,imagebyte, flag[0], flag[2], flag[1], flag[3]);
&nbsp;
            if (result == "0")
            {
                       if (gsobj.GenerateDefaultGesture(url,imagebyte))
                        {
                            err[0].Add("Success");
                            err[0].Add("");
                            return err;
                        }
                        else
                        {
                            if (gsobj.error != "")
                            {
                                err[0].Add("");
                                err[0].Add(gsobj.error);
                                return err;
                            }
                            err[0].Add("Please follow the Gesture");
                            err[0].Add("");
                            return err;
                        }
            }
            else
            {
                err[0].Add(result);
                err[0].Add("");
                return err;
            }
}
</code>
            </pre>
        </blockquote>
<li>Replace the whole code of ImageValidationAPI() in HomeController.cs</li>
        <blockquote>
            <pre>
                <code>
public JsonResult ImageValidationAPI(string data, string check)
{
    string imgefile = "Img" + $@"{System.DateTime.Now.Ticks}.jpg";
    string Url = Server.MapPath(@"~\Images\" + imgefile);
    System.IO.File.WriteAllBytes(Url, Convert.FromBase64String(data));
    var imagebyte = Facade.storetoserver(data);
&nbsp;
    List&lt;List&lt;string&gt;&gt; result = Facade.User_ImageValidation(check, imagebyte, imgefile);
&nbsp;
    if (result[0][1] == "")
    {
        return Json(new { Result = result[0][0] });
    }
&nbsp;
    return Json(new { Result = "Failed" });
}
                </code>
</pre></blockquote></strong>
</ol>
<h3>Invoke the User_Registration() of Facade Class from HomeController</h3>
<ol>
<strong>
   <li>Paste the code given below in 'HomeController.cs', (i.e) below the comment 'Paste the 'FaceRegisterAPI' Function code here...'</li>
   <blockquote>
     <pre>
       <code>
//Face Register API
public JsonResult FaceRegisterAPI(string data, string name, string gender, string phone, string email)
{
    var imagebyte = Facade.storetoserver(data);
&nbsp;
    List&lt;List&lt;string&gt;&gt; result = Facade.User_Registration(name, gender, phone, email, imagebyte);
&nbsp;
    if (result[0][1] == "")
    {
        return Json(new { Result = result[0][0] });
    }
&nbsp;
    return Json(new { Result = result[0][1] });
}
       </code>
   </pre>
</blockquote>
</strong>
</ol>
<h3>Invoke the Verify API</h3>
<ol>
  <strong>
    <li>Paste the code given below in 'StorageHandler.cs', (i.e) below the comment 'Paste the 'VerifyTimeTable' Class code here...'</li>
    <blockquote>
        <pre>
           <code>
public class VerifyTimeTable
{
    //Connection String
    private static string connectionString = ConfigurationManager.AppSettings["AzureSqlConnectionString"];
    public string error = "";
&nbsp;
    public bool CheckIn(string personid, string date, string time)
    {
&nbsp;
        try
        {
            // Initialization 
            SqlConnection conn;
            SqlCommand cmd;
&nbsp;
            using (conn = new SqlConnection(connectionString))
            {
                // Selecting the perticular row in the table and updating that using particular ID 
                cmd = new SqlCommand("IF NOT EXISTS(SELECT * FROM verifytime WHERE personid = '" + personid + "' AND date = '"+date+ "') INSERT INTO verifytime(personid, date, checkin) VALUES('" + personid + "','" + date + "','" + time + "')", conn);
                //connection open
                conn.Open();
                var temp = cmd.ExecuteNonQuery();
                //connection close
                conn.Close();
                if (temp > 0)
                    return true;
                return false;
            }
        }
        catch (Exception e)
        {
            error = e.Message;
            // Returning the result
            return false;
        }
    }
&nbsp;
    public bool CheckOut(string personid,string date,string time)
    {
&nbsp;
        try
        {
            // Initialization 
            SqlConnection conn;
            SqlCommand cmd;
&nbsp;
            using (conn = new SqlConnection(connectionString))
            {
                // Selecting the perticular row in the table and updating that using particular ID 
                cmd = new SqlCommand("IF EXISTS(SELECT * FROM verifytime WHERE personid = '" + personid + "' AND date = '" + date + "') UPDATE verifytime set checkout ='" + time + "' WHERE personid = '" + personid + "' AND date = '" + date + "'", conn);
                //connection open
                conn.Open();
                var temp = cmd.ExecuteNonQuery();
                //connection close
                conn.Close();
                if (temp > 0)
                    return true;
                return false;
            }
        }
        catch (Exception e)
        {
            error = e.Message;
            // Returning the result
            return false;
        }
    }

}
           </code>
           </pre>
       </blockquote>
   </strong>
</ol>
<h3>Invoke the FaceRegistrationHandler Class from Facade</h3>
<ol>
<strong>
<li>Paste the code given below in 'Facade.cs', (i.e) below the comment 'Paste the 'User_Verification' Function Code here...'</li>
<blockquote>
 <pre>
   <code>
public static List&lt;List&lt;string&gt;&gt; User_Verification(string url, byte[] imagebyte, string gesture, bool CheckIn)
{
    List&lt;List&lt;string&gt;&gt; err = new List&lt;List&lt;string&gt;&gt;();
    err.Add(new List&lt;string&gt;());
&nbsp;
    GestureHandler gshobj = new GestureHandler();
    FaceRegistrationHandler frhobj = new FaceRegistrationHandler();
&nbsp;
        if (gshobj.Validate(url, imagebyte, gesture))
        {
            string result = frhobj.VerifyFace(imagebyte, CheckIn);
            err[0].Add(result);
            err[0].Add("");
            return err;
&nbsp;
        }
        else
        {
            if (gshobj.error != "")
            {
                err[0].Add("Failed");
                err[0].Add(gshobj.error);
                return err;
            }
&nbsp;
            err[0].Add("Failed");
            err[0].Add("Please follow the gesture and try again");
            return err;
        }  
}
   </code>
</pre>
</blockquote>
</strong>
</ol>
<h3>Invoke the User_Verification() of Facade Class from HomeController</h3>
<ol>
<strong>
   <li>Paste the code given below in 'HomeController.cs', (i.e) below the comment 'Paste the 'VerifyAPI' Function code here...'</li>
   <blockquote>
     <pre>
       <code>
//Verify API
public JsonResult VerifyAPI(string data, string random_gesture, bool CheckIn)
{
    var imagebyte = Facade.storetoserver(data);
    string imgefile = "Img" + $@"{System.DateTime.Now.Ticks}.jpg";
    string Url = Server.MapPath(@"~\Images\" + imgefile);
    System.IO.File.WriteAllBytes(Url, Convert.FromBase64String(data));
&nbsp;
    List&lt;List&lt;string&gt;&gt; result = Facade.User_Verification(imgefile, imagebyte, random_gesture, CheckIn);
&nbsp;
    if (result[0][1] == "")
    {
        return Json(new { Result = "Success", VerifiedName = result[0][0] });
    }
&nbsp;
    return Json(new { Result = "Failed", VerifiedName = result[0][1] });
}
       </code>
   </pre>
</blockquote>
</strong>
</ol>
<h3>Till this you can run the solution and get the output</h3>
<p>In the browser, navigate to User -> Register page</p>
<ol>
    <li>Click on the toggle button</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Register/reg_1.jpg" alt="image" style="max-width: 100%;">
    <li>Browse page will be displayed</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Register/reg_2.JPG" alt="image" style="max-width: 100%;">
    <li>Click on the Browse button</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Register/reg_3.jpg" alt="image" style="max-width: 100%;">
    <li>Select the image and click on Submit</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Register/reg_4.jpg" alt="image" style="max-width: 100%;">
    <li>If all the image validations are passed your image will display in the right side</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Register/reg_5.JPG" alt="image" style="max-width: 100%;">
    <li>Fill the details and click on submit [Note : Name field is mandatory]</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Register/reg_6.jpg" alt="image" style="max-width: 100%;">
    <li>Success message will be displayed</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Register/reg_7.jpg" alt="image" style="max-width: 100%;">
</ol>
<p>Navigate to User -> Verify page </p>
<ol>
    <li>Click on the toggle button</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Verify/verify_1.jpg" alt="image" style="max-width: 100%;">
    <li>Click on the Browse button</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Verify/verify_2.jpg" alt="image" style="max-width: 100%;">
    <li>Select the image, click open</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Verify/verify_3.jpg" alt="image" style="max-width: 100%;">
    <li>Click on Check-in</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Verify/verify_5.jpg" alt="image" style="max-width: 100%;">
    <li>Welcome message will be displayed along with your check-in time</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Verify/verify_6.jpg" alt="image" style="max-width: 100%;">
    <li>If check-in button was again clicked, error message will be shown</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Verify/verify_7.jpg" alt="image" style="max-width: 100%;">
    <li>Click on Check-out button</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Verify/verify_8.jpg" alt="image" style="max-width: 100%;">
    <li>Good Bye message will be displayed along with your check out time</li>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Verify/verify_9.jpg" alt="image" style="max-width: 100%;">
</ol>
<h3>Invoking Audit Log</h3>
<ol>
    <strong>
        <li>Paste the code given below in 'Facade.cs', (i.e) below the comment 'Paste the 'Admin_AuditLogShow' Function Code here...'</li>
        <blockquote>
            <pre>
                <code>
public static List&lt;audit_log&gt; Admin_AuditLogShow()
{
            AuditLoggerTable altobj = new AuditLoggerTable();
&nbsp;
            return altobj.List();
}
</code>
            </pre>
        </blockquote>
    </strong>
<strong>
   <li>Paste the code given below in 'HomeController.cs', (i.e) Replace the whole ActionResult 'audit_log'</li>
   <blockquote>
     <pre>
       <code>
        public ActionResult audit_log()
        {
            // Calling the intermediator file and Returing the List file to the View 
            return View(Facade.Admin_AuditLogShow());
        }
       </code>
   </pre>
</blockquote>
</strong>
</ol>
<h3>Invoking Audit Log design changes</h3>
<li>Click on auditlog.cshtml</li>
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Audit_Log/1.PNG" alt="image" style="max-width: 100%;">
<li>Uncomment the code from line 220</li>
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Audit_Log/2.PNG" alt="image" style="max-width: 100%;">
<li>Uncomment the code till line 264</li>
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Audit_Log/3.PNG" alt="image" style="max-width: 100%;">
<li>Click on the uncomment button</li>
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Audit_Log/4.png" alt="image" style="max-width: 100%;">
<p>Now you can run and check the Audit Log outputs</p>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Audit_Log/auditlog.JPG" alt="image" style="max-width: 100%;">
<h3>Congratulations! You have successfully completed Challenge 3</h3>
<h3>The next session is<a href="https://github.com/jumpstartninjatech/HeroSolutions-AI/blob/master/Challenge4.md"> Challenge 4</a></h3>