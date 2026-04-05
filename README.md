# Face Detection App (C# - Emgu CV)

## 📌 Description

This project is a simple Face Detection application built using C# and Emgu CV (OpenCV wrapper).

The program loads an image, detects faces using a Haar Cascade classifier, draws rectangles around detected faces, and saves the result.

---

## 🚀 Features

* Detect faces in an image
* Draw rectangles around faces
* Save output image (`result.jpg`)
* Display number of detected faces

---

## 🛠️ Technologies Used

* C#
* Emgu CV (OpenCV for .NET)
* Haar Cascade Classifier

---

## 📁 Project Structure

```
FaceDetectionApp/
│
├── Program.cs
├── person.jpg
├── result.jpg
└── data/
    └── haarcascade_frontalface_default.xml
```

---

## ▶️ How to Run

1. Open the project in Visual Studio
2. Make sure Emgu CV packages are installed
3. Place an image named `person.jpg` in the project folder
4. Run the program

---

## 📷 Output

* The program generates a new image:

```
result.jpg
```

with rectangles around detected faces.

---

## 🧠 How It Works

1. Load the image
2. Convert it to grayscale
3. Use Haar Cascade to detect faces
4. Draw rectangles around faces
5. Save the result

---

## 📌 Example Output

```
Done!
Faces found: 1
```

---

## 👨‍💻 Author

Mahmoud Bakar
