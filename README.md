# fast-open-unityAPI

针对国内用户打开unity自带API时速度很慢的问题，
工程中提供了一个名称为OffLineDocumentation的脚本，
将其挂在任意一个空物体上，然后在enPath中写上unity英文文档的本地路径（比如我的是D:\ApplicationInstallPath\Unity5.1.1p4\Editor\Data\Documentation\en），运行后，
以后打开API就很快了

原理：去除了“http：//”标示，以免产生不必要的连接
