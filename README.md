# BillTheDev's Full Window WebGL Template

A Unity WebGL template that provides a full-window experience and a basic loading bar.

## Features

*   **Full-window display:**  The template is designed to make your WebGL game occupy the entire browser window with no scrollbars.
*   **Basic Loading Bar:**  A simple loading bar is included to provide visual feedback during the loading process.
*   **Easy to use:**  Install the package via the Unity Package Manager and select the "FullWindowTemplate" in your WebGL build settings.

## Installation

1.  **Add the package via Git URL:**  In your Unity project, open the Package Manager (`Window > Package Manager`). Click the "+" button in the upper left corner and select "Add package from git URL...".
2.  **Enter the Git URL:**  Paste the following URL into the field: `https://github.com/truongbill003/FullWindowWebGLTemplate.git` 
3.  **Select the template in Build Settings:**  Open `File > Build Settings`, select the WebGL platform, and click "Player Settings...".  In the Inspector window, under "Publishing Settings", find the "WebGL Template" option and select "FullWindowTemplate".

## Usage

After installing the package and selecting the template, build your Unity project for WebGL as usual. The resulting build will use the full-window template.

## Customization

*   **Styling:** Edit the `Assets/WebGLTemplates/FullWindowTemplate/style.css` file to customize the appearance of the page, including background colors, text styles, and the loading bar.
*   **Loading Bar:** Modify the loading bar appearance and behavior within `Assets/WebGLTemplates/FullWindowTemplate/index.html`.
*   **Favicon:** Replace `Assets/WebGLTemplates/FullWindowTemplate/favicon.ico` with your own favicon.

## Author

BillTheDev - [My Portfolio](http://billthedev.com)
## License

This template is released under the [MIT License](LICENSE.txt).  