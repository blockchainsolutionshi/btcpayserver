using System;
using NBitcoin;

namespace BTCPayServer
{
    public partial class BTCPayNetworkProvider
    {
        public void InitMakanaAssets()
        {
            var nbxplorerNetwork = NBXplorerNetworkProvider.GetFromCryptoCode("MKNA");
            Add(new ElementsBTCPayNetwork()
            {
                CryptoCode = "ATMp",
                NetworkCryptoCode = "MKNA",
                DefaultRateRules = new[]
                {
                    "ATMP_UST = 1",
                    "ATMP_USD = 1",
                    "ATMP_X = ATMP_BTC * BTC_X",
                    "ATMP_BTC = bitfinex(USD_BTC)",
                    "ATMP_MKNA = ATMP_BTC",
                },
                AssetId = new uint256("9d2e1355933081ef1bc34c293be7f44e21238536bfb9f1002b6bd2f8c9a87ce4"),
                DisplayName = "ATM Coin",
                BlockExplorerLink = NetworkType == NetworkType.Mainnet ? "https://blockstream.info/liquid/tx/{0}" : "https://blockstream.info/testnet/liquid/tx/{0}",
                NBXplorerNetwork = nbxplorerNetwork,
                UriScheme = "makananetwork",
                CryptoImagePath = "imlegacy/liquid-tether.svg",
                DefaultSettings = BTCPayDefaultSettings.GetDefaultSettings(NetworkType),
                CoinType = NetworkType == NetworkType.Mainnet ? new KeyPath("1776'") : new KeyPath("1'"),
                SupportRBF = true
            });

        }
    }


}
