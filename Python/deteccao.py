import cv2

# classificador pré-treinado de detecção de rostos
face_cascade = cv2.CascadeClassifier(cv2.data.haarcascades + 'haarcascade_frontalface_default.xml')

# detectar rostos
def detect_faces(image):
    # cinza
    gray_image = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)

    # detectar rostos
    faces = face_cascade.detectMultiScale(gray_image, scaleFactor=1.1, minNeighbors=5, minSize=(30, 30))

    # retângulo e mensagem nos rostos
    for (x, y, w, h) in faces:
        cv2.rectangle(image, (x, y), (x+w, y+h), (0, 255, 0), 2)
        
        cv2.putText(image, "Rosto detectado", (x, y-10), cv2.FONT_HERSHEY_SIMPLEX, 0.5, (0, 255, 0), 1, cv2.LINE_AA)

    return image

video = cv2.VideoCapture(0)


while True:
    _, frame = video.read()
    frame_with_faces = detect_faces(frame)
    
    cv2.imshow('Resultado', frame_with_faces)
    if cv2.waitKey(1) == 27:
        # 'ESC'
        break

video.release()
cv2.destroyAllWindows()