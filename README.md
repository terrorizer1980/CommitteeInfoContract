# CommitteeInfoContract

## Contract Hash

* **mainnet:** pending

* **testnet:** 0x8eb75ceff1e3b28a2bfbb1f4d0511647de9a1c1d


------
## Update Committee Info

### Method Name:
**setinfo**

### Parameters

| ParameterName | Type | Description |
| ---- | ---- | ---- |
| sender | Hash160 | Committee address, require sign |
| name | String | Committee name |
| location | String | Committee location |
| website | String | Committee website url |
| email | String | Committee email |
| github | String | Committee github account |
| telegram | String | Committee telegram |
| twitter | String | Committee twitter |
| description | String | Committee description |
| logo | String | Committee logo's FS ID |

### Invoke by GUI

[gui1]()
[gui2]()

### Invoke by neo-cli

```
invoke 0x8eb75ceff1e3b28a2bfbb1f4d0511647de9a1c1d setInfo [{"type":"Hash160","value":"0x429688538c267d5da7a03fbe7b8e4cf45d6e9826"},{"type":"String","value":"MyName"},{"type":"String","value":"MyLocation"},{"type":"String","value":"http://mysite.com"},{"type":"String","value":"myemail@mail.com"},{"type":"String","value":"mygithub"},{"type":"String","value":"mytelegram"},{"type":"String","value":"mytwitter"},{"type":"ByteArray","value":"VGhpcyBpcyBhbiBleGFtcGxlLg=="},{"type":"String","value":"mylogoID"}] NPS3U9PduobRCai5ZUdK2P3Y8RjwzMVfSg NPS3U9PduobRCai5ZUdK2P3Y8RjwzMVfSg


```

------
