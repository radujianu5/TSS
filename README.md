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

Tool de testare prin mutații: Stryker.NET (versiune X.X.X)

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

Start
  ↓
Se verifică dacă parola este null sau goală
  ↓        ↓
 Da       Nu
 Mesaj   Se verifică lungimea parolei
           ↓        ↓
         <8       ≥8
        Mesaj      Se verifică dacă are literă mare
                    ↓        ↓
                 Nu         Da
                Mesaj       Se verifică dacă are cifră
                              ↓        ↓
                            Nu         Da
                           Mesaj       Se verifică dacă are caracter special
                                         ↓        ↓
                                       Nu         Da
                                      Mesaj       Mesaj: „Parola este validă”

5. Testare unitară

Testele folosesc framework-ul xUnit și acoperă toate cazurile posibile, inclusiv:

Parolă goală sau null.

Parolă prea scurtă.

Lipsa unei litere mari.

Lipsa unei cifre.

Lipsa unui caracter special.

Parolă complet validă.

Mai mult, au fost adăugate teste suplimentare pentru omorârea mutanților neechivalenți generați de Stryker.

6. Testare prin mutații (Mutation Testing)

Pentru a verifica eficiența testelor, a fost folosit tool-ul Stryker.NET care introduce modificări artificiale în cod (mutanți). Testele trebuie să detecteze aceste modificări (să „omoare” mutanții).

Rezultate:
Toți mutanții generați au fost prinși (omorâți).

Nu există mutanți supraviețuitori (survivors).

Aceasta atestă o suită de teste robustă și o acoperire foarte bună.

Raportul Stryker complet este disponibil în folderul StrykerOutput.

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





