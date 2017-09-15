## 简介
AD2UART是一款基于串口采集模拟量的工具，目前最高可周期1毫秒采集4通道16位的AD信号。

## 通信协议
每帧数据由10字节组成，每通道2字节（高字节在前，低字节在后），每字节8位（高数据位在前，低数据位在后）。

byte0  |  byte1  |  byte2  |  byte3  |  byte4 
-----|------|------|------|------
AD1高字节|AD1低字节|AD2高字节|AD2低字节|AD3高字节

  byte5  |  byte6  |  byte7  |  byte8  |  byte9
|------|------|------|------|-----
AD2低字节|AD4高字节|AD2低字节|固定字0x13 |固定字0x10 


## 编译下载
最新测试版：[AD2UART.exe](https://raw.githubusercontent.com/xiaoxinpro/AD2UART/master/AD2UART/bin/Debug/AD2UART.exe)