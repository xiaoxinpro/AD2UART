## 简介
AD2UART是一款基于串口采集模拟量的工具，目前最高可周期1毫秒采集4通道16位的AD信号。

## 通信协议
每帧数据由10字节组成，每通道2字节（高字节在前，低字节在后），每字节8位（高数据位在前，低数据位在后）。

```
byte0 - 1 : AD1通道数据
byte2 - 3 : AD2通道数据
byte4 - 5 : AD3通道数据
byte6 - 7 : AD4通道数据
byte8 - 9 : 结尾字节（0x13 0x10）
```

## 编译下载
最新测试版：[AD2UART.exe](https://raw.githubusercontent.com/xiaoxinpro/AD2UART/master/AD2UART/bin/Debug/AD2UART.exe)
