<h1>Hackathon</h1>
<h2>Challenge 4 – Quality Control of PDI Verification</h2>
<p>In Challenge 4, you have to use Azure Custom Vision API to create Quality Control Checker.</p>
<h2>Getting Started</h2>
<h3>Prerequisites</h3>
<li>Kindly ensure that the application works fine so far.</li>
<li>Build the Quality Control Checker in the same application.</li>
<h3>Code Summary</h3>
<p>For Quality Control Checking you have to create two model files using the Azure Custom Vision API. Both the model files should find the Quality of the products. While testing the Quality of the product you can get the images from the live stream and the other on by browsing the image from the local machine or using the image URL.</p>
<h3>Invoke the Quality Controller Check API</h3>
<ol>
  <strong>
      <li>Train your model and publish it in 'customvision.ai' [NOTE : Check <a href="">Challenge 2</a> for procedures]</li>
      <li>For training, get the image data-set from <a href="">here</a>.</li>
  </strong>
</ol>
<strong>
<h3>Objective : Finding the Quality of a product using Azure Custom Vision API</h3>
<h3>Psuedo Code : </h3>
<p>STEP 1 : Create two functions for those model files and each function should return Pass/Fail response</p>
<p>STEP 2 : In front end create two Radio Buttons for those model files, while selecting model 1 Radio Button it should call the model 1 Quality checker functionalities and show the response in front end and the same procedure for model 2.</p>
<p>STEP 3 : If you decide to take the picture by live streaming, make sure you use the correct product. If the Image does not contain any related product details, it will throw the 'Fail' response.</p>
<p>STEP 4 : If you click the Browse Button for selecting an image, make sure you select the relevant image.</p>
<p>STEP 5 : If you enter the URL for selecting an image, make sure you give the right path for the image.</p>
</strong>
<h2>Model 1 Sample Outputs</h2>
<li>Selecting the Model 1 Check Box</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_1.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Turning off the Live Streamming and selecting the Browse Button</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_2.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Opening the wrong product image from a folder</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_3.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Below is the picture of a wrong product</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_4.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Open the Right product image from the folder</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_5.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Below is the picture of the Right product and its showing <b>Fail</b> as a response</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_6.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Selecting the wrong file type</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_7.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Below is the Error page which you will get after selecting the wrong file type</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_8.PNG" alt="image" style="max-width:100%;">&nbsp;
<h3>URL images</h3>
<li>Error page for Empty URL</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_9.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Giving wrong product path</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_10.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Giving right product path</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model1_output/output_11.PNG" alt="image" style="max-width:100%;">&nbsp;
<h2>Model 2 Sample Outputs</h2>
<li>Selecting the Model 2 Check Box</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model2_output/output1.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Error page for selecting the No Space image</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model2_output/output2.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Error page for selecting the Long Space image</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model2_output/output3.PNG" alt="image" style="max-width:100%;">&nbsp;
<li>Error page for selecting the Accurate image</li>&nbsp;
<img src="http://139.59.61.161/Hackathon/MSWorkshop2019/Quality_Check/Model2_output/output4.PNG" alt="image" style="max-width:100%;">&nbsp;
<h3>Congratulations! You have successfully completed Challenge 4</h3>
<h3>The next session is <a href="https://github.com/jumpstartninjatech/AI-TechSeries/blob/master/Challenge5.md">Challenge 5</a></h3>