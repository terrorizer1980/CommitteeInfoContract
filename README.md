# CommitteeInfoContract

## Contract Hash

* **mainnet:** pending

* **testnet:** 0x8eb75ceff1e3b28a2bfbb1f4d0511647de9a1c1d


------
## Update Committee Info

### Method Name: **setInfo**

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
![001](https://user-images.githubusercontent.com/7391819/125911981-89c12f1d-2a12-4c06-9fff-0454eaad63ff.png)
![002](https://user-images.githubusercontent.com/7391819/125911998-32a2cfc0-abee-4a87-99a3-a6ea7f81d87a.png)
![003](https://user-images.githubusercontent.com/7391819/125912023-04494f31-0ace-47ea-a5d5-98660218d64f.png)

### Invoke by neo-cli

```
invoke 0x8eb75ceff1e3b28a2bfbb1f4d0511647de9a1c1d setInfo [{"type":"Hash160","value":"0x429688538c267d5da7a03fbe7b8e4cf45d6e9826"},{"type":"String","value":"MyName"},{"type":"String","value":"MyLocation"},{"type":"String","value":"http://mysite.com"},{"type":"String","value":"myemail@mail.com"},{"type":"String","value":"mygithub"},{"type":"String","value":"mytelegram"},{"type":"String","value":"mytwitter"},{"type":"ByteArray","value":"VGhpcyBpcyBhbiBleGFtcGxlLg=="},{"type":"String","value":"mylogoID"}] NPS3U9PduobRCai5ZUdK2P3Y8RjwzMVfSg NPS3U9PduobRCai5ZUdK2P3Y8RjwzMVfSg


```

------
