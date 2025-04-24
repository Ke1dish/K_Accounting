[Setup]
AppName=Мои финансы
AppVersion=1.25.4.18
DefaultDirName={autopf}\Мои финансы
DefaultGroupName=Мои финансы
OutputBaseFilename=K_Accounting_Setup
OutputDir=C:\Users\Keldish\source\repos\Ke1dish\K_Accounting\Instal
ArchitecturesAllowed=x64
ArchitecturesInstallIn64BitMode=x64
Compression=lzma2
SolidCompression=yes
SourceDir=C:\Users\Keldish\source\repos\Ke1dish\K_Accounting\bin\Release\net8.0-windows\win-x64
ShowLanguageDialog=yes
LanguageDetectionMethod=locale
LicenseFile=Licenses\license_ru.txt

[Languages]
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"; LicenseFile: "Licenses\license_ru.txt"
Name: "english"; MessagesFile: "compiler:Default.isl"; LicenseFile: "Licenses\license_en.txt"

[CustomMessages]
russian.LicenseAccepted=Я &принимаю условия соглашения
russian.LicenseNotAccepted=Вы должны принять условия соглашения
english.LicenseAccepted=I &accept the agreement
english.LicenseNotAccepted=You must accept the agreement

[Messages]
russian.BeveledLabel=Русская версия
russian.WelcomeLabel1=Добро пожаловать в установку "Мои финансы"
russian.WelcomeLabel2=Программа будет установлена в следующую папку.%n%nНажмите Далее для продолжения или Отмена для выхода.
russian.SelectDirDesc=Куда установить "Мои финансы"
russian.SelectDirLabel3=Установочная папка:
russian.SelectStartMenu=Выберите папку в меню Пуск
russian.SelectAdditionalTasks=Выберите дополнительные задачи
russian.InstallingLabel=Идет установка "Мои финансы"
russian.FinishedLabel=Программа "Мои финансы" успешно установлена.
russian.WizardLicense=Лицензионное соглашение
russian.LicenseLabel=Пожалуйста, прочтите лицензионное соглашение
english.WizardLicense=License Agreement
english.LicenseLabel=Please read the license agreement

[Files]
Source: "K_Accounting.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "*.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "*.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "*.json"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\Мои финансы"; Filename: "{app}\K_Accounting.exe"
Name: "{commondesktop}\Мои финансы"; Filename: "{app}\K_Accounting.exe"

[Tasks]
Name: "desktopicon"; Description: "Создать значок на рабочем столе"

[Code]
function InitializeSetup(): Boolean;
begin
  Result := True;
end;

[CustomMessages]
russian.LaunchProgram=Запустить "Мои финансы" после установки

[Run]
Filename: "{app}\K_Accounting.exe"; Description: "{cm:LaunchProgram}"; Flags: postinstall nowait skipifsilent