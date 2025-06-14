Proiect de testare - Generator de parole ]n C#
 
 1. Descrierea proiectului

Proiectul PasswordManager este o aplicație simplă în C# care validează parole conform unor reguli stricte de securitate.
Aplicația include o clasă PasswordValidator ce oferă funcționalitatea principală de validare a parolei, verificând următoarele condiții:

Parola să nu fie goală.

Lungimea minimă să fie de 8 caractere.

Să conțină cel puțin o literă mare.

Să conțină cel puțin o cifră.

Să conțină cel puțin un caracter special dintr-un set prestabilit.

2. Tehnologii și configurare

Limbaj: C# 

Framework: .NET 8

IDE: Visual Studio 2022

Framework testare unitară: xUnit

Tool de testare prin mutații: Stryker.NET (versiune 4.7.0)

Sistem de operare: Windows 10/11

Mașină virtuală: nu este utilizată

3. Structura proiectului

PasswordManager/PasswordValidator.cs – conține clasa principală pentru validarea parolelor.

PasswordManager.Tests/PasswordValidatorTests.cs – conține testele unitare pentru clasa PasswordValidator.

Folderul StrykerOutput – conține rapoartele generate de Stryker pentru testarea prin mutații.

4. Cum funcționează codul (explicație + diagramă)

Clasa PasswordValidator are o metodă principală:

public string ValidatePassword(string? password)
care returnează un mesaj specific pentru fiecare situație detectată (ex: „Parola este prea scurtă”, „Parola este validă”).

Cum funcționează:

![image](https://github.com/user-attachments/assets/db7b6453-9606-4610-9dea-415b1377e530)
![image](https://github.com/user-attachments/assets/461d3e1a-7928-4857-8155-a8288279f8e6)
![image](https://github.com/user-attachments/assets/719d2972-6fc8-41ea-a8f2-bdc691714e12)
![image](https://github.com/user-attachments/assets/21496439-46df-4fee-9e73-8e70c701a738)
![image](https://github.com/user-attachments/assets/a22febc3-4aa6-4475-bdce-3cf8ef3ec209)
![image](https://github.com/user-attachments/assets/24788d50-32f9-437d-bf09-47f4164a4dde)



5. Testare unitară

Testele folosesc framework-ul xUnit și acoperă toate cazurile posibile, inclusiv:

Parolă goală sau null.

Parolă prea scurtă.

Lipsa unei litere mari.

Lipsa unei cifre.

Lipsa unui caracter special.

Parolă complet validă.

Mai mult, au fost adăugate teste suplimentare pentru omorârea mutanților neechivalenți generați de Stryker.

6. 🧬 Cum funcționează testarea mutanților pentru validatorul de parole
Testarea mutanților este o tehnică avansată de testare care verifică eficiența testelor unitare. Cu ajutorul unui instrument precum Stryker.NET, codul validatorului de parole este modificat automat prin introducerea unor "defecte simulate" numite mutanți. Scopul este de a observa dacă testele existente detectează aceste modificări.

🔍 Ce face Stryker.NET?
Introduce mutanți, de exemplu:

schimbă == în !=,

înlocuiește && cu ||,

inversează condiții (if (x > 5) → if (x <= 5)),

scoate sau modifică return-uri.

Rulând testele existente pe versiunea „infectată” a codului, detectează dacă testele reușesc să omoare mutanții (adică să eșueze când codul e greșit).

Dacă un mutant nu este detectat de teste, el supraviețuiește, indicând un punct slab în acoperirea testelor.

🧪 Cum a fost aplicat în proiect?
În cazul validatorului de parole, au fost introduși mutanți în logica de verificare a:

parolelor goale,

lungimii minime,

prezenței unei litere mari,

unei cifre,

unui caracter special.

Testele au acoperit toate aceste cazuri, provocând eșecul codului modificat — astfel, toți mutanții au fost omorâți.

✅ Concluzie
Rata de omorâre a mutanților: 100%

Testele unitare sunt robuste și validează corect toate cerințele funcționale ale validatorului.

Acest proces asigură încredere în calitatea și rezistența codului.

![Screenshot 2025-06-14 142243](https://github.com/user-attachments/assets/7f7486b5-c859-4ac1-853f-e2af4ac6e869)
![image](https://github.com/user-attachments/assets/887adbaa-d93a-47ce-b8fe-c6edf674957b)


7. Utilizarea AI în dezvoltare

Pentru optimizarea scrierii testelor și a codului, am folosit ChatGPT, pentru:

Sugestii privind structura codului și a testelor.

Ajutor la generarea testelor suplimentare pentru mutații.

Interpretarea rapoartelor și recomandări de îmbunătățire.

| Aspect            | Teste scrise manual | Teste generate cu AI |
| ----------------- | ------------------- | -------------------- |
| Corectitudine     | Foarte ridicată     | Foarte ridicată      |
| Acoperire mutanți | 100%                | Similară             |
| Timp de creare    | Mai mare            | Mai rapid            |
| Complexitate cod  | Ușor de urmărit     | Ușor de urmărit      |

8. Cum se rulează proiectul?

Deschide soluția în Visual Studio 2022.

Setează proiectul PasswordManager ca startup project.

Pentru a rula testele unitare, deschide Test Explorer și rulează toate testele.

Pentru testarea prin mutații, deschide terminalul în folderul cu testele și rulează:
dotnet stryker

9. Referințe bibliografice

xUnit.net – https://xunit.net/

Stryker.NET – https://stryker-mutator.io/

Microsoft Docs .NET – https://docs.microsoft.com/en-us/dotnet/

OpenAI ChatGPT – https://chat.openai.com/

10. 🤖Capturi din "discuția" cu chatGPT pentru ajutorul asupra proiectului
![image](https://github.com/user-attachments/assets/56006971-33c4-40df-a915-5d04b58fe7ee)
![image](https://github.com/user-attachments/assets/49f83535-8209-49e0-a39c-edcfe35b6a3f)
![image](https://github.com/user-attachments/assets/fae95f22-5c8a-4da8-bbb3-38c03595493b)
![image](https://github.com/user-attachments/assets/9409078c-9a4d-4ade-8381-8e66d631a38d)

Pentru acest proiect, am folosit ChatGPT ca ajutor în scrierea logicii de validare a parolelor și a testelor unitare. AI-ul m-a ghidat pas cu pas în crearea regulilor, generarea de cazuri de test și în configurarea testării mutanților. A fost util mai ales la clarificarea conceptelor și economisirea timpului.








