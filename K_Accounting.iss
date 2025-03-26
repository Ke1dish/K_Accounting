[Setup]
AppName=Мои финансы
AppVersion=1.0
DefaultDirName={autopf}\Мои финансы
DefaultGroupName=Мои финансы
OutputBaseFilename=K_Accounting_Setup
OutputDir=C:\Users\Keldish\source\repos\Ke1dish\K_Accounting\bin\Release\net8.0-windows\win-x64\Instal
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
var
  DotNetVersion: String;
  ResultCode: Integer;
begin
  // Проверка наличия .NET 8 Desktop Runtime
  if not RegQueryStringValue(
    HKEY_LOCAL_MACHINE,
    'SOFTWARE\dotnet\Setup\InstalledVersions\x64\sharedhost',
    'Version',
    DotNetVersion) 
  or (CompareStr(DotNetVersion, '8.0.0') < 0) then
  begin
    if MsgBox(
      'Для работы K_Accounting требуется .NET 8 Runtime.' + #13#10 +
      'Установить сейчас? (требуется интернет-соединение)',
      mbConfirmation, MB_YESNO) = IDYES 
    then begin
      ShellExec(
        'open',
        'https://download.visualstudio.microsoft.com/download/pr/815a0e0c-38f9-4f12-8933-03d9f6b6f0a2/6e6157f370a39ee0cc5a5d54770dbb3e/windowsdesktop-runtime-8.0.0-win-x64.exe',
        '',
        '',
        SW_SHOW,
        ewNoWait,
        ResultCode);
    end;
  end;
  
  Result := True;
end;

[CustomMessages]
russian.NetFrameworkMissingTitle=Требуется .NET Framework
russian.NetFrameworkMissing=Для работы приложения необходимо установить .NET 8 Runtime.
russian.LaunchProgram=Запустить "Мои финансы" после установки

[Run]
Filename: "{app}\K_Accounting.exe"; Description: "{cm:LaunchProgram}"; Flags: postinstall nowait skipifsilent