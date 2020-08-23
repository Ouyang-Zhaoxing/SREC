# SREC

[![version](https://img.shields.io/badge/version-0.9.10.20200823-blue.svg?style=flat-square)](https://srec-1251216093.file.myqcloud.com/SREC.zip)
[![license](https://img.shields.io/github/license/Ouyang-Zhaoxing/SREC.svg?style=flat-square)](https://github.com/Ouyang-Zhaoxing/SREC/blob/master/LICENSE)

轻量级的绿色便携屏幕录制、直播工具。

## **如何使用**
点击上方 **version** 标签下载 【Ctrl+F11】启动录制 【Ctrl+F12】停止录制


## **新功能！**
支持RTMP推流直播！

1. 在托盘菜单设置中填写你的直播地址
2. 打开托盘菜单的直播选项

小提示：B站直播地址 = 你的rtmp地址 + 你的直播码

![rtmpimg](https://srec-1251216093.file.myqcloud.com/rtmpimg.png)


## **编码器**
目前支持CPU、英特尔QSV和英伟达NVENC三种编码器。

默认为CPU编码，个别设备可能会出现录制内容绿屏花屏等问题，请切换到其他编码器。


## **FAQ**

**为什么我使用 QSV/NVENC 硬件编码器时无效？**

使用硬件编码器无效时，请更新对应的显卡驱动或前往官网查看设备是否支持。

~~**为什么我无法录制系统声音？**~~

~~程序默认只捕获屏幕（作为屏幕记录器使用），录制系统声音需要第三方插件支持，请从托盘菜单中安装 **Screen Capture Recorder**（已集成 **Virtual Audio Capture** ）~~

~~**注册插件时需要管理员权限，我希望知道程序对我的计算机做了哪些更改，或者我是否可以手动注册插件？**~~

~~手动注册和卸载插件方法：~~

~~注册：`regsvr32 DLLPath`~~

~~卸载：`regsvr32 /u DLLPath`~~

~~程序做了一样的事情。~~

**插件功能暂时关闭**


## 计划中的一些事
- 更好的用户界面
- 添加对自定义选框和固定窗口录制的支持
- 添加对摄像头的支持
- 添加可布局的直播界面
- 直播的完善和性能优化
- 开放全面的高级设置


## **开发**
- 建议使用 [Visual Studio 2017](https://visualstudio.microsoft.com/) 或更高版本
- .NET Framework 4.6 开发人员包


## **许可证**
[MIT License](https://github.com/Yiwei-Brunhlio/SREC/blob/master/LICENSE)
