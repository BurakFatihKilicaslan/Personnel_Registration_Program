# Personnel_Registration_Program
A study has been carried out in such a way that the user can manage and view the data belonging to the employees of the company for which she is authorized, and change the existing files.

Admin Screen: Admin can add and delete company officials. The account of the company official can be frozen and a notification is made with the warning that the access of the authorized person whose account is frozen is restricted to the system and that he/she should inform the Manager by giving feedback. On the login screen, the status of the user is determined according to the user name and password, and the use of the necessary screens is allowed according to the user status.
Admin User Information;
User UserName(Kullanıcı Adı) = 01234567890;
Password(Şifre) = KD15kadikoy++

Except for the administrator, the personnel working in the program should only be in the authorized status and authorized personnel can perform all registration processes. The deletion process is controlled by the administrator. In addition, SHA-256 (Secure Hash Algorithm 256-bit) is recorded in the database via a cryptographic hash operation, as the password information must be securely stored and compared during the registration process.

Authorized User information;
User UserName(Kullanıcı Adı) = 98765432100;
Password(Şifre) = burakBFK95**


# Notes
Operations were carried out by writing clean code in OOP logic by using Entity, DAL, BLL, PL layers within the framework of layered architectural structure and rules.
