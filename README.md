# Controlling MX OPC with C#
- Used in the Project <br>
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white) - v2022<br>
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)<br>
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) - 6.0<br>

# Required Programs
<img src="https://drive.google.com/uc?export=view&id=1vnKKPSc7y49XuTwCEOd8DT1Yd6Qp5KGc"> Factory IO
3D factory simulation for automation technologies. Allows to build a virtual factory using a selection of common industrial parts.

<img src="https://drive.google.com/uc?export=view&id=1Ce426YO1MTslauwWPRQki9CSI-TeghjN"> MX OPC Configurator<br>
Allows users to access data from a MELSEC programmable controller using the OPC format

<img src="https://drive.google.com/uc?export=view&id=1F-Qp7uRD5quDFHZX9vl4SSi0P05CHn4w"> MELSEC GX Works3 <br> 
Latest generation of programming and maintenance software offered by Mitsubishi Electric specifically designed for the MELSEC iQ-R and MELSEC iQ-F Series control system.

# Download Required Files

[Click to download](https://drive.google.com/file/d/130snpXUlYq7Fev1TQcrRnjnw97-Eh-Kz/view?usp=share_link)

# Installation

<h3>Factory IO</h3>
<ul>
  <li>Go to <strong>Documents/Factory IO/My Scenes</strong> and copy the <strong>StartStopConveyor.factoryio</strong> file there</li>
  <li>Open <strong>Factory IO</strong></li>
  <li>Click the <strong>Scenes</strong> menu</li>
  <li>Open the scene you just added from <strong>My Scenes</strong></li>
</ul>

<h3>MX OPC Configurator</h3>
<ul>
  <li>Open <strong>MX OPC Configurator</stong></li>
  <li>Go to <strong>File</strong> menu from the top left</li>
  <li>Select <strong>CSV Import</strong> option</li>
  <li>Import the <strong>mxopc_tags.csv</strong> file</li>
</ul>

<h3>MELSOFT GX Works3</h3>
<ul>
  <li>Open <strong>MELSOFT GX Works3</strong></li>
  <li>Go to </strong>Project</strong> menu from the top left</li>
  <li>Select <strong>Open</strong> option</li>
  <li>Open <strong>GXStartStop.gx3</strong> file</li>
</ul>

# Usage
<ol>
  <li>Make sure MX OPC is running. (by clicking the <strong>green arrow</strong> in the <strong>menu</strong> in the MX OPC Configurator)</li>
  <li>Open MELSEC GX Works3. </li>
  <li>Convert the project <strong>by pressing the F4 key (or clicking "Convert/Convert(B)" from the top menu)</strong></li>
  <li>Start the simulation by clicking <strong>"Debug/Simulation/Start Simulation"</strong> in the top menu)</li>
  <li>Run the C# program</li>
  <li>Select <strong>"SistemStart"</strong> tag from the combobox named <strong>"Tags"</strong></li>
  <ul>
    <li>Select value <strong>"1"</strong>(to start the simulation) from the combobox named <strong>"Value"</strong></li>
    <li>Select value <strong>"0"</strong>(to stop the simulation) from the combobox named <strong>"Value"</strong></li>
  </ul>
</ol>
