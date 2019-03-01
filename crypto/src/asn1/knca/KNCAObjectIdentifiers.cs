namespace Org.BouncyCastle.Asn1.KZ
{
  /**
   * Kazakhstan object identifiers
   */
  public abstract class KNCAObjectIdentifiers
  {
    private static readonly DerObjectIdentifier caKzId = new DerObjectIdentifier("1.2.398.3");
    private static readonly DerObjectIdentifier pkiGovKzId = caKzId.Branch("10.1");

    public static readonly DerObjectIdentifier Gost34311x95WithGost34310x2004 = pkiGovKzId.Branch("1.1.2");
    public static readonly DerObjectIdentifier Gost34311x95 = pkiGovKzId.Branch("3.1");
    public static readonly DerObjectIdentifier Gost34310x2004 = pkiGovKzId.Branch("1.1.1");
    public static readonly DerObjectIdentifier Gost34311x95TestParamSet = pkiGovKzId.Branch("3.1.1.0");
    public static readonly DerObjectIdentifier Gost34310x2004PkiGovKzA = pkiGovKzId.Branch("1.1.1.1");
  }
}
