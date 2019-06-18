<h1>AI Tech Series – Hackathon</h1>
<h1>Challenge 2 – Gesture Management</h1>
<p>In this Challenge 2, you have to use the Azure Custom Vision portal to create the Gesture Management.</p>
<h2>Getting Started</h2>
<h3>Prerequisites</h3>
<li>Kindly ensure that the application works fine so far.</li>
<h3>Code Summary</h3>
<p>For this gesture management, you should use five gestures to verify the users [which was already there in the <b>gesture</b> table]. All the details of the <b>gesture</b> table should be displayed in the Admin page. The Admin must have the authority to Enable or Disable the gestures. Also, they can add new gestures in the gesture management.</p>
<p><b>NOTE : </b>Create the Gesture management under <b>Admin</b> part [ADMIN -> GESTURE MANAGEMENT]</p>
<h3>Invoke the Gesture Management API</h3>
<ol>
  <strong>
      <li>Train your model in 'customvision.ai' [For training, get the images from <a href="https://github.com/jumpstartninjatech/AI-TechSeries/tree/master/HOL/AI_Series_Starter_Kit/images/GestureImages">here</a>]</li>
      <li>After training your model publish it</li>&nbsp;
      <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/custom/custom1.jpg" alt="image" style="max-width: 100%;">&nbsp;
      <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/custom/custom2.jpg" alt="image" style="max-width: 100%;">&nbsp;
      <li>Click on Prediction URL</li>&nbsp;
      <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/custom/custom3.jpg" alt="image" style="max-width: 100%;">&nbsp;
      <li>Grab your endpoint, project-id and iteration name.</li>&nbsp;
      <img src="http://139.59.61.161/Hackathon/custom6.1.jpg" alt="image" style="max-width: 100%;">&nbsp;
      <li>Copy your Project ID</li>&nbsp;
      <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/custom/custom7.jpg" alt="image" style="max-width:100%;">&nbsp;
      <img src="http://139.59.61.161/Hackathon/MSWorkshop2019/custom/custom8.jpg" alt="image" style="max-width:100%;">&nbsp;
  </strong>
</ol>
<h3>Objective : Manage the Gestures from the admin page</h3>
<h3>Pseudo code : </h3>
<p><b>STEP 1: </b>Create a function, which is used to fetch all the default gestures from the gesture table [there are five default gestures in the <b>gesture</b> table] and display all those gestures in the front end. All these details should be displayed in the gesture management page under admin part.</p>
<p>The following pictures are the example for navigating to the gestures management page,</p>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Admin/admin_1_hackathon.PNG" alt="image" style="max-width:100%;">&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Admin/admin_index_2_hackathon.png" alt="image" style="max-width:100%;">&nbsp;
<li>Sample output for showing all the default gestures in the front end</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Challenge2/output/1.JPG" alt="image" style="max-width: 100%;">&nbsp;
<p><b>STEP 2: </b>Create a function, which is used to add the new gesture in the <b>gesture</b> table, while the user clicks on the <b>Add Gestures</b> button.</p>
<p>The pictures shown below are the examples for adding new gesture in <b>gesture</b> table</p>&nbsp;
<li>Adding the new Gesture, when <b>Add Gesture</b> button clicks</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Challenge2/output/2.jpg" alt="image" style="max-width: 100%;">&nbsp;
<li>Create a Modal box for Adding a new Gesture</li>&nbsp
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Challenge2/output/3.jpg" alt="image" style="max-width: 100%;">&nbsp;
<li>Provide the relevant information to add a new Gesture</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Challenge2/output/4.jpg" alt="image" style="max-width: 100%;">&nbsp;
<li>Added a New Gesture</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Challenge2/output/5.jpg" alt="image" style="max-width: 100%;">&nbsp;
<p><b>STEP 3: </b>Create a function, which is used to handle the updations, when the user clicks the <b>Edit</b> button</p>
<p>The pictures shown below are the examples for Editing the gestures in admin page</p>
<li>Clicking edit button to edit a Gesture</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Challenge2/output/6.jpg" alt="image" style="max-width: 100%;">&nbsp;
<li>After clicking the edit button it should display the relevant details in the modal box</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Challenge2/output/7.JPG" alt="image" style="max-width: 100%;">&nbsp;
<li>By clicking the button shown below you should be able to disable the Gesture</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Challenge2/output/8.jpg" alt="image" style="max-width: 100%;">&nbsp;
<li>Disabled button</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Challenge2/output/9.jpg" alt="image" style="max-width: 100%;">&nbsp;
<li>Update button is used to update the Gesture details in the <b>gesture</b> table</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Challenge2/output/10.jpg" alt="image" style="max-width: 100%;">&nbsp;
<li>Changes are shown below</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Challenge2/output/11.jpg" alt="image" style="max-width: 100%;">&nbsp;
<h3>Congratulations! You have successfully completed Challenge 2</h3>
<h3>The next session is<a href="https://github.com/jumpstartninjatech/AI-TechSeries/blob/master/Challenge3.md"> Challenge 3</a></h3>
