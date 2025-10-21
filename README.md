Acesta e repo-ul echipei formate din Matcovici Georgiana si Turetchi Adriana.

Lab3: Am creat mana in Blender, i-am adaugat textura si am importat-o in Unity ca mana stanga si dreapta (cu scale -1 pe X) pentru cele 2 controllere.

Lab2:
Am facut setup-ul OpenXR + XRToolkit + XR Device simulator.
Obiectele sunt apucate de controller cu grab, la release sunt aruncate si in momentul in care ating targetul se incrementeaza scorul din UI (partea dreapta a ecranului).
Video de prezentare: https://youtu.be/OY1I51_t4IE

Lab1:
Am plasat cele doua personaje pe cate un image tracker, am configurat setup-ul in Animator astfel incat la apasarea tastei Enter personajul intra in atac, la apasarea tastei Space in idle, iar cand se detecteaza un cactus la mai putin de 0.25m se face tranzitia de la idle la attack si inapoi la idle cand distanta creste peste 0.25.
Ca si bonus, am adaugat RigidBody si BoxColliders pe cei 2 cactusi, iar cand unul dintre ei detecteaza o coliziune cu celalalt (OnTriggerEnter), face tranzitia la animatia Dead.
Pentru a putea incarca pe github proiectul, am eliminat din pachetele vuforia.
Video de prezentare: https://youtu.be/HK_Yzx5Gc9k
