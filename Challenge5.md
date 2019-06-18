<h1>AI Tech Series - Hackathon</h1>
<h2>Challenge 5 – Optical Character Recognizer and Automatic Key Phrases Extraction</h2>
<p>In this Challenge 5, you have to create the Legal Document Verification using Azure Custom Vision API and Microsoft Luis</p>
<h2>Getting Started</h2>
<h3>Prerequisites</h3>
<li>Kindly ensure that the application works fine so far</li>
<li>Build the Legal Document Verification in the same application</li>
<h3>Code Summary</h3>
<p>In Legal Document Verification you have to do two things. The first one is OCR (Optical Character Recognizer), its an API which you need to create using Azure Custom Vision. It is used to find the character in a given document or an image. Use OCR, to get the text from the input (document/image)</p>
<p>After you got all the text, you need to do the Automatic Keyword Extraction using Microsoft LUIS.</p>
<h3>Objective: Legal Document Verification using OCR and LUIS</h3>
<h3>Creating Cognitive service API Key for OCR</h3>
<ol>
  <strong>
    <li>Sign-in to Azure Portal by typing "portal.azure.com" in browser, enter your username</li>&nbsp;
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_computer_portal/computervisionAPI_create/portal_1.jpg" alt="image" style="max-width: 100%;">&nbsp;
    <li>Enter your Password</li>&nbsp;
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_computer_portal/computervisionAPI_create/portal_2.jpg" alt="image" style="max-width: 100%;">&nbsp;
    <li>Click on create a resource</li>&nbsp;
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_computer_portal/computervisionAPI_create/portal_3.jpg" alt="image" style="max-width: 100%;">&nbsp;
    <li>In the search box type <b>cognitive service</b></li>&nbsp;
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_computer_portal/computervisionAPI_create/portal_4.jpg" alt="image" style="max-width: 100%;">&nbsp;
    <li>Click on create</li>&nbsp;
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_computer_portal/computervisionAPI_create/portal_5.jpg" alt="image" style="max-width: 100%;">&nbsp;
    <li>Enter name and select location, pricing tier and resource group</li>&nbsp;
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_computer_portal/computervisionAPI_create/portal_6.jpg" alt="image" style="max-width: 100%;">&nbsp;
    <li>Click on Overview tab</li>&nbsp;
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_computer_portal/computervisionAPI_create/portal_7.jpg" alt="image" style="max-width: 100%;">&nbsp;
    <li>Copy the endpoint</li>&nbsp;
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_computer_portal/computervisionAPI_create/portal_8.jpg" alt="image" style="max-width: 100%;">&nbsp;
    <li>Click on Keys tab</li>&nbsp;
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_computer_portal/computervisionAPI_create/portal_9.jpg" alt="image" style="max-width: 100%;">&nbsp;
    <li>Copy the Keys</li>&nbsp;
    <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/face_computer_portal/computervisionAPI_create/portal_10.jpg" alt="image" style="max-width: 100%;">&nbsp;
  </strong>
</ol>
<h3>Importing the LUIS Model</h3>
<ol>
    <strong>
        <li>Download the LUIS Json file from <a href="https://github.com/jumpstartninjatech/AI-TechSeries/blob/master/HOL/e569a3f6-4254-4060-a326-3a6372d0b419_v0.1.json">GitHub</a></li>&nbsp;
        <li>Login to Luis.ai</li>&nbsp;
        <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/LuisImages/1.jpg" alt="image" style="max-width: 100%;">&nbsp;
        <li>Enter your username</li>&nbsp;
        <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/LuisImages/2.jpg" alt="image" style="max-width: 100%;">&nbsp;
        <li>Enter your password</li>&nbsp;
        <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/LuisImages/3.jpg" alt="image" style="max-width: 100%;">&nbsp;
        <li>Click on Import app</li>&nbsp;
        <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/LuisImages/4.jpg" alt="image" style="max-width: 100%;">&nbsp;
        <li>Select the Json file</li>&nbsp;
        <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/LuisImages/5.jpg" alt="image" style="max-width: 100%;">&nbsp;
        <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/LuisImages/6_hackathon.jpg" alt="image" style="max-width: 100%;">&nbsp;
        <li>Enter name</li>&nbsp;
        <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/LuisImages/7_hackathon.jpg" alt="image" style="max-width: 100%;">&nbsp;
        <li>Click on Train button</li>&nbsp;
        <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/custom/LUIS2.jpg" alt="image" style="max-width: 100%;">&nbsp;
        <li>After training is completed, click on Publish button</li>&nbsp;
        <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/custom/LUIS3.jpg" alt="image" style="max-width: 100%;">&nbsp;
        <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/custom/LUIS1.JPG" alt="image" style="max-width: 100%;">&nbsp;
        <li>Click on Manage</li>&nbsp;
        <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/LuisImages/8.jpg" alt="image" style="max-width: 100%;">&nbsp;
        <li>Copy the Application ID</li>&nbsp;
        <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/LuisImages/9.jpg" alt="image" style="max-width: 100%;">&nbsp;
        <li>Copy Key and Endpoint</li>&nbsp;
        <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/LuisImages/10.jpg" alt="image" style="max-width: 100%;">&nbsp;
    </strong>
</ol>
<h3>Invoke the Optical Character Recognizer API</h3>
<h3>Pseudo code : </h3>
<p><b>STEP 1 : </b>Now, lets test the image using Azure API.</p>
<p><b>STEP 2 : </b>If you choose to take the picture by live streaming, make sure you use the correct image. If the Image does not contain any text, it will throw the 'Fail' response.</p>
<p><b>STEP 3 : </b>If you click the Browse Button for selecting an image, make sure you select the relevant image.</p>
<p><b>STEP 4 : </b>If you enter the URL for selecting an image, make sure you give the right path for the image.</p>
<h2>Sample Output</h2>
<h3>Browse Button for selecting images from the Local Machine</h3>
<li>Turn off the Live Streaming and select the Browse Button</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_2.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Open the Right image from the folder</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/OCR/2.png" alt="image" style="max-width:100%;">&nbsp;
<li>Below is the screenshot of the Right image</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/OCR/3.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Select the wrong file type</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_7.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Error page if you select a wrong file type</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_8.PNG" alt="image" style="max-width:100%;">&nbsp;
<h3>Congratulations! You have successfully completed Challenge 5</h3>
<h3>The next session is <a href="https://github.com/jumpstartninjatech/AI-TechSeries/blob/master/Challenge6.md">Challenge 6</a></h3>