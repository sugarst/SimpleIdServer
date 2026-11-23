// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using FormBuilder.Components.FormElements.Divider;
using FormBuilder.Conditions;
using FormBuilder.Models;

namespace FormBuilder.Builders;

public class DividerLayoutRecordBuilder
{
    private readonly DividerLayoutRecord _record;

    internal DividerLayoutRecordBuilder()
    {
        _record = new DividerLayoutRecord
        {
            Id = Guid.NewGuid().ToString(),
            CorrelationId = Guid.NewGuid().ToString()
        };
    }

    public DividerLayoutRecordBuilder AddTranslation(string language, string value, IConditionParameter conditionParameter = null)
    {
        _record.Labels.Add(new LabelTranslation(language, value, conditionParameter));
        return this;
    }

    internal DividerLayoutRecord Build()
    {
        return _record;
    }
}
