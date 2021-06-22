/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OperatoraccesscontrolService.Models
{
  /// <summary>
  /// Infrastructure layers available to be governed under operator control
    /// - DOM0
    /// - CellServer
    /// - CPS (Control Plane Server)
    /// 
  /// </summary>
  public enum InfrastrcutureLayers {
      [EnumMember(Value = "DOM0")]
      Dom0,
      [EnumMember(Value = "CELLSERVER")]
      Cellserver,
      [EnumMember(Value = "CPS")]
      Cps
  }
}