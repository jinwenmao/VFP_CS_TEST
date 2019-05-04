

在命令提示符下面，进入Dll所在的目录

C:\Windows\system32>cd/d E:\MyLib\MyLib\bin\Debug

用 gacutil /i MyLib.dll 将这个DLL加入的全局缓存里

E:\MyLib\MyLib\bin\Debug>gacutil/i mylib.dll

然后用 regasm MyLib.dll 注册这个dll

E:\MyLib\MyLib\bin\Debug>regasmmylib.dll