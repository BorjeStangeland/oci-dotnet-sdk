/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.CimsService.Models
{
  /// <summary>
  /// Available OCI Regions supported by CIMS. eg: PHX, IAD
  /// </summary>
  public enum Region {
      [EnumMember(Value = "DEV")]
      Dev,
      [EnumMember(Value = "SEA")]
      Sea,
      [EnumMember(Value = "INTEG_NEXT")]
      IntegNext,
      [EnumMember(Value = "INTEG_STABLE")]
      IntegStable,
      [EnumMember(Value = "PHX")]
      Phx,
      [EnumMember(Value = "IAD")]
      Iad,
      [EnumMember(Value = "FRA")]
      Fra,
      [EnumMember(Value = "EU_FRANKFURT_1")]
      EuFrankfurt1,
      [EnumMember(Value = "LHR")]
      Lhr,
      [EnumMember(Value = "YYZ")]
      Yyz,
      [EnumMember(Value = "NRT")]
      Nrt,
      [EnumMember(Value = "US_LANGLEY_1")]
      UsLangley1,
      [EnumMember(Value = "US_LUKE_1")]
      UsLuke1,
      [EnumMember(Value = "ICN")]
      Icn,
      [EnumMember(Value = "BOM")]
      Bom,
      [EnumMember(Value = "GRU")]
      Gru,
      [EnumMember(Value = "US_GOV_ASHBURN_1")]
      UsGovAshburn1,
      [EnumMember(Value = "US_GOV_PHOENIX_1")]
      UsGovPhoenix1,
      [EnumMember(Value = "US_GOV_CHICAGO_1")]
      UsGovChicago1,
      [EnumMember(Value = "SYD")]
      Syd,
      [EnumMember(Value = "ZRH")]
      Zrh,
      [EnumMember(Value = "JED")]
      Jed,
      [EnumMember(Value = "AMS")]
      Ams,
      [EnumMember(Value = "KIX")]
      Kix,
      [EnumMember(Value = "MEL")]
      Mel,
      [EnumMember(Value = "YUL")]
      Yul,
      [EnumMember(Value = "HYD")]
      Hyd,
      [EnumMember(Value = "YNY")]
      Yny,
      [EnumMember(Value = "TIW")]
      Tiw
  }
}