import cv2
import numpy as np
from pyscreeze import screenshot


img = screenshot()


img_np = np.array(img)
img_np = cv2.cvtColor(img_np, cv2.COLOR_RGB2BGR)


img_flipped = cv2.flip(img_np, 1)


cv2.imshow('Imagem Invertida', img_flipped)
cv2.waitKey(0)
cv2.destroyAllWindows()