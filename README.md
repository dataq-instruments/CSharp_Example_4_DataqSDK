# DataqSDK
 Skeleton C# Example based on DataqSDK ActiveX
 
 This C# example is based on DATAQsdk ActiveX. It targets DI-2108, but it also supports DI-11xx, DI-21xx, DI-41xx and DI-47xx and others with appropriate modification, such as DeviceDriver and DeviceID, gain/range difference, please refer to https://www.dataq.com/data-acquisition/software/developer-network/#3

Requirements:<br/>
  Installation of VisualStudio (32-bit)<br/>
  Installation of Dataq Software Suite<br/>
  Dataq Instruments devices that support DataqSDK ActiveX<br/> 
  For more info about DataqSDK ActiveX, please refer to https://www.dataq.com/products/dataq-active-x/features.html

When you download and build this project for the first time, good chance you will run in an error like "Couldn't process file form1.resx due to its being in the internet or Restricted zone or having the mark of the web on the file. Remove the mark of the web if you want to process these files."

To deal with it, you will need to locate the offending .resx files in solution directory, right click on it, open the properties and check the option "unblock". Repeat this for all offending .resx files before reloading the project

![alt text](https://www.dataq.com/resources/repository/resxunblock.png "how to unblock resx files")
