# 🎵 Audio Steganography - Hide Secret Messages in Audio Files

![.NET](https://img.shields.io/badge/.NET-6.0-blue)
![License: MIT](https://img.shields.io/badge/License-MIT-green)

> ✨ **Description:**  
> This project implements the **LSB (Least Significant Bit)** method to hide secret text, image, and video files inside **.wav** audio files using **C# .NET**.  
> The original audio quality is preserved while securely and invisibly embedding the messages.

## 📑 Contents  
- [📜 About the Project](#about-the-project)  
- [⚡ Features](#features)  
- [🧩 Algorithm Overview](#algorithm-overview)  
- [⚙️ Installation and Usage](#installation-and-usage)  
- [📊 Sample Output](#sample-output)  
- [🛠 Technologies](#technologies)  
- [🤝 Contributing](#contributing)  
- [📄 License](#license)  
- [📬 Contact](#contact)

<a id="about-the-project"></a>
## 📜 About the Project  
Audio Steganography is a technique that hides secret messages by manipulating the least significant bits of audio files.

This project:  
- 🎙️ Processes .wav audio files  
- 🔍 Converts secret text, image, and video files into binary format  
- 🌿 Embeds message bits into audio data using the Fibonacci sequence  
- 🔊 Preserves the original audio quality  
- 📂 Generates new audio files containing the hidden messages

<a id="features"></a>
## ⚡ Features  
✅ Secure message hiding using the LSB method  
✅ Support for embedding text, image, and video files  
✅ Bit placement guided by the Fibonacci sequence  
✅ Turkish character support  
✅ Management of original and modified audio files  
✅ User-friendly Windows Forms interface

<a id="algorithm-overview"></a>
## 🧩 Algorithm Overview  
1. Convert the audio file bytes into binary format.  
2. Convert the secret file (text, image, or video) into binary format.  
3. Use the Fibonacci sequence to determine bit positions for embedding.  
4. Modify the binary audio data accordingly.  
5. Convert the modified binary data back to bytes and create a new .wav file.  
6. Extract and verify the hidden message from the audio file.

<a id="installation-and-usage"></a>
## ⚙️ Installation and Usage  
1. 📥 Clone the repository:  
   ```bash
   git clone https://github.com/leventDemirkaya/audio-steganography.git
   cd audio-steganography
2. 💻 Open the project in Visual Studio or run it using the dotnet CLI.
3. 🎵 Use the program interface to select a .wav file, choose the secret text, image, or video file to embed, and embed the message.
4. 🔊 Listen to the generated audio file or extract the hidden message to verify.

<a id="sample-output"></a>
## 📊 Sample Output
### 🎙️ Selected Audio File
example.wav

### 📝 Secret Message
Hello, this is a secret message.

### 🔢 Binary Message Parts
01001101 01100101 01110010 01101000 01100001 01100010 01100001 ...

### 🎧 Generated Audio File
hidden1.wav

### 📬 Extracted Message
Hello, this is a secret message.

<a id="techologies"></a>
## 🛠 Technologies
- 💻 C#
- 🖥 .NET Framework / .NET 6.0
- 🎨 Windows Forms
- 🎵 NAudio library

<a id="contributing"></a>
## 🤝 Contributing
💡 Your contributions are highly appreciated!
- 🐛 Report issues via the Issues tab.
- 🚀 Submit pull requests for improvements.

<a id="license"></a>
## 📄 License
📝 This project is licensed under the MIT License. See the LICENSE file for details.

<a id="contact"></a>
## 📬 Contact
📧 leventdemirkaya@outlook.com
