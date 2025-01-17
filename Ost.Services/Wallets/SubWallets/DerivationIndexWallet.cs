﻿namespace Ost.Services.Wallets.SubWallets
{
    /// <summary>
    /// Represents a derivation index based wallet.
    /// </summary>
    public class DerivationIndexWallet : IDerivationIndexWallet
    {
        /// <inheritdoc cref="IDerivationIndexWallet.DerivationIndex"/>
        public int DerivationIndex { get; init; }

        /// <inheritdoc cref="IAliasedWallet.Alias"/>
        public string Alias { get; set; }
    }
}
