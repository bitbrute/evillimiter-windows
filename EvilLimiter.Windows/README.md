# Evil Limiter for Windows

[![License Badge](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://GitHub.com/Naereen/StrapDown.js/graphs/commit-activity)
[![HitCount](http://hits.dwyl.io/bitbrute/evillimiter-windows.svg)](http://hits.dwyl.io/bitbrute/evillimiter-windows)
[![Open Source Love](https://badges.frapsoft.com/os/v3/open-source.svg?v=102)](https://github.com/ellerbrock/open-source-badge/)

A tool to limit the bandwidth (upload/download) of devices connected to your network without physical or administrative access.
evillimiter employs ARP spoofing and traffic shaping to throttle the bandwidth of hosts on the network. This is explained in detail below.

This tool is the Windows GUI port of the original CLI tool [Evil Limiter](https://github.com/bitbrute/evillimiter) for Linux.

## Requirements

- Windows 7 or higher

Missing requirements (including 3rd party applications, like [Npcap](https://nmap.org/npcap/)) will be installed when running the setup.

## Installation

1. Run setup file
2. Follow the instructions
3. If not already installed, you will be instructed to install [Npcap](https://nmap.org/npcap/). Make sure to install it in WinPcap API-compatible mode (check the checkbox).

<p align="left" style="margin-left:33px"><img src="https://i.imgur.com/uxKz5qg.png" /></p>

4. Run Evil Limiter


## Restrictions

- **Limits IPv4 connctions only**, since [ARP spoofing](https://en.wikipedia.org/wiki/ARP_spoofing) requires the ARP packet that is only present  on IPv4 networks.

## Disclaimer

[Evil Limiter for Windows](y) is provided by [bitbrute](https://github.com/bitbrute) "as is" and "with all faults". The provider makes no representations or warranties of any kind concerning the safety, suitability, lack of viruses, inaccuracies, typographical errors, or other harmful components of this software. There are inherent dangers in the use of any software, and you are solely responsible for determining whether this software is compatible with your equipment and other software installed on your equipment. You are also solely responsible for the protection of your equipment and backup of your data, and the provider will not be liable for any damages you may suffer in connection with using, modifying, or distributing this software.

## License

Copyright (c) 2019 by [bitbrute](https://github.com/bitbrute). Some rights reserved.<br>
[Evil Limiter for Windows](https://github.com/bitbrute/evillimiter-windows) is licensed under the MIT License as stated in the [LICENSE file](LICENSE).