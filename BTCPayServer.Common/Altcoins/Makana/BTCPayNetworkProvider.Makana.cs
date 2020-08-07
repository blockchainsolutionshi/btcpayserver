using System;
using BTCPayServer;
using NBitcoin;
using NBitcoin.Altcoins;
using NBitcoin.Altcoins.Elements;
using NBXplorer;

namespace BTCPayServer
{
    public partial class BTCPayNetworkProvider
    {
        public void InitMakana()
        {
            var nbxplorerNetwork = NBXplorerNetworkProvider.GetFromCryptoCode("MKNA");
            Add(new ElementsBTCPayNetwork()
            {
                AssetId = NetworkType == NetworkType.Mainnet ? ElementsParams<Makana>.PeggedAssetId : ElementsParams<Makana.MakanaRegtest>.PeggedAssetId,
                CryptoCode = "MKNA",
                NetworkCryptoCode = "MKNA",
                DisplayName = "Makana",
                DefaultRateRules = new[]
                {
                    "MKNA_X = MKNA_BTC * MKNA_X",
                    "MKNA_BTC = 1",
                    "MKNA_USD = bitfinex(BTC_USD)",
                },
                BlockExplorerLink = NetworkType == NetworkType.Mainnet ? "https://blockstream.info/liquid/tx/{0}" : "https://blockstream.info/testnet/liquid/tx/{0}",
                NBXplorerNetwork = nbxplorerNetwork,
                UriScheme = "mknanetwork",
                CryptoImagePath = "imlegacy/liquid.png",
                DefaultSettings = BTCPayDefaultSettings.GetDefaultSettings(NetworkType),
                CoinType = NetworkType == NetworkType.Mainnet ? new KeyPath("1776'") : new KeyPath("1'"),
                SupportRBF = true
            });
        }
    }
}
