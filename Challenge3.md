<h1>AI Tech Series – Hackathon</h1>
<h1>Challenge 3 – Face Registration, Verification & Audit Log</h1>
<p>In this Challenge 3, you have to use Azure Face Register API, Azure Face Verify API and should handle the Audit log of the whole application.</p>
<h2>Getting Started</h2>
<h3>Prerequisites</h3>
<li>Kindly ensure that the application works fine so far.</li>
<h3>Code Summary</h3>
<p>For the Face Registration, you should use three Azure face APIs [<b>Create Person API</b>, <b>Add Face API</b> and <b>Train API</b>]. For the Face Verification, you should use two Azure Face APIs [<b>Detect API</b> and <b>Identify API</b>]. In the Admin part, you have to display all the audit logs in the Audit Log page.</p>
<p>Create the Face registration and Face verification under <b>User</b> part, where as Audit Log under <b>Admin</b> part.</p>
<h3>Create Group ID</h3>
  <ol>
    <strong>
      <li>Follow the below steps and create the group id</li>
      <li>Navigate to <a href="https://southeastasia.dev.cognitive.microsoft.com/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395244">Developer Portal</a>, click on 'PersonGroup' tab on the left pane</li>&nbsp;
      <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_group_id/face_1.jpg" alt="image" style="max-width: 100%;">&nbsp;
      <li>Click on 'Create' tab on the left pane</li>&nbsp;
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
<h3>Pseudo code : </h3>
<p><b>STEP 1 : </b>The user should be able to take a snapshot from the livestream or to be able to select a local image [Provide both the options]</p>
<p><b>STEP 2 : </b>Call the <b>Image Validation</b> function which you have created in the Challenge 1 to validate the image given by the user</p>
<p><b>STEP 3 : </b>You have to call the Face registration API Only when the four attributes specified in the <b>Image Validation function</b> are succeeded</p>
<h3>Objective : Invoke the Register API</h3>
<h3>Pseudo code : </h3>
<p><b>STEP 1 : </b>Using Azure Face API you have to do the Face registration</p>
<p><b>STEP 2 : </b>Create a function, in which you have to call three Azure Face APIs for registering the face in Azure</p>
<p><b>STEP 3 : </b>First call the <b>Create Person API</b> and get the <b>Person ID</b> from the json response</p>
<p><b>STEP 4 : </b>To call the <b>Create Person API</b> you need the <b>Create Person API</b> Endpoint, Face API Key, Group ID and Person Name [the name that you have got from the user]</p>
<p><b>STEP 5 : </b>Now you have to call the <b>Add Face API</b></p>
<p><b>STEP 6 : </b>To call the <b>Add Face API</b> you need the Person ID [(i.e) <b>Create Person API</b>'s response]</p>
<p><b>STEP 7 : </b>Finally call the <b>Train API</b> and get the success response</p>
<p><b>STEP 8 : </b>To call the <b>Train API</b> you need the Group ID and Face API Key</p>
<p><b>STEP 9 : </b>If all the four attributes of <b>Image Validation function</b> are succeeded the image will be displayed in the right side</p>
<p><b>STEP 10 : </b>Get the name, mobile number, email and gender from the user and store those details in the <b>usertable</b> along with the Person ID you got from the <b>Create Person API</b></p>
<h3>Objective : Call the gesture randomly</h3>
<h3>Pseudo code : </h3>
<p><b>STEP 1 : </b>There will be already five gestures in the <b>gesture</b> table, create a function for which you have to call any one of the gesture randomly from the table and display it in the front end</p>
<p><b>STEP 2 : </b>The user has to show the gesture (which you are displaying randomly) in front of the camera, you have to call the Azure's Custom Vision API [user gesture image as input] to find what gesture the user has shown</p>
<p><b>STEP 3 : </b>Compare the Custom Vision API response [gesture type] and the gesture you have randomly displayed, if both the gesture type matches then proceed with the Face Verification or else display the error message.</p>
<h3>Objective : Invoke the Verify API</h3>
<h3>Pseudo code : </h3>
<p><b>STEP 1 : </b>Using Azure Face API you have to do the Face verification</p>
<p><b>STEP 2 : </b>Create a function, in which you have to call two Azure Face APIs for verifying the face</p>
<p><b>STEP 3 : </b>First call the <b>Detect API</b> and get the <b>Face ID</b> from the json response</p>
<p><b>STEP 4 : </b>To call the <b>Detect API</b> you need the <b>Detect API</b> Endpoint, Face API Key and input image</p>
<p><b>STEP 5 : </b>Now you have to call the <b>Identify API</b></p>
<p><b>STEP 6 : </b>To call the <b>Identify API</b> you need the Face ID [(i.e) <b>Detect API</b>'s response], Face API Key and endpoint</p>
<p><b>STEP 7 : </b>You will get the Person ID as the response from <b>Identify API</b></p>
<p><b>STEP 8 : </b>Now compare this Person ID with the Person ID stored in the <b>usertable</b></p>
<p><b>STEP 9 : </b>If both the Person ID matches then display the Person Name of that Person ID</p>
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
<h3>Objective : Invoke Audit Log</h3>
<h3>Pseudo code : </h3>
<p><b>STEP 1 : </b>You have to store every entries in the <b>auditlog</b> table</p>
<p><b>STEP 2 : </b>That is store the input images in every stage in the table along with the result type [(i.e) Pass or Fail]</p>
<h3><b>NOTE : </b>The following procedures are needed only when you are using the 'AI Series Starter Kit' application</h3>
<p>Un-comment the code in design screens</p>
<ol>
<strong>
<li>Open auditlog.cshtml [In solution explorer, Views -> Home -> auditlog.cshtml]</li>
<li>Select the code from line number 220</li>
<li>Select the code till line number 264</li>
<li>Click on the uncomment button</li>
<li>If you are using this option you have to create your own model class also accordingly or else you can skip the above steps and handle that feature in your own way.</li>
</ol>
<p>Now you can run and check the Audit Log outputs</p>
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Audit_Log/auditlog.JPG" alt="image" style="max-width: 100%;">
<h3>Congratulations! You have successfully completed Challenge 3</h3>
<h3>The next session is<a href="https://github.com/jumpstartninjatech/AI-TechSeries/blob/master/Challenge4.md"> Challenge 4</a></h3>