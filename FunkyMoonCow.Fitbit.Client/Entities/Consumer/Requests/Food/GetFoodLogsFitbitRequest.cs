﻿using System;
using System.Collections.Generic;

namespace FunkyMoonCow.Fitbit
{
  /// <summary>
  /// Provides a <see cref="FitbitRequest"/> for getting food logs.
  /// </summary>
  public class GetFoodLogsFitbitRequest : FitbitRequest
  {
    /// <summary>
    /// Gets or sets the user identifier.
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DateTime.Date"/>.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="FitbitUnit"/>.
    /// </summary>
    public FitbitUnit Units { get; set; }

    /// <summary>
    /// Intialises a new instance of the <see cref="GetFoodLogsFitbitRequest"/> class.
    /// </summary>
    public GetFoodLogsFitbitRequest()
    {
      this.UserId = FitbitUser.Current.ToString();
      this.Date = DateTime.Today;
    }

    /// <summary>
    /// Gets the endpoint URI.
    /// </summary>
    /// <returns>The URI.</returns>
    public override string GetUri()
    {
      return string.Format(
          "/1/user/{0}/foods/log/date/{1}.json",
          this.UserId,
          this.Date.ToString("yyyy-MM-dd")
        );
    }

    /// <summary>
    /// Gets the headers.
    /// </summary>
    /// <returns>A <see cref="IEnumerable{FitbitRequestHeader}"/></returns>
    public override IEnumerable<FitbitRequestHeader> GetHeaders()
    {
      var headers = new List<FitbitRequestHeader>();

      if (this.Units != null)
      {
        headers.Add(
          new FitbitRequestHeader(
            "Accept-Language",
            this.Units.ToString()
          )
        );
      }

      return headers;
    }
  }
}