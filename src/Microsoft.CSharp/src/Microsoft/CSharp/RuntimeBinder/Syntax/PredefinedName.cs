// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CSharp.RuntimeBinder.Syntax
{
    internal enum PredefinedName
    {
        PN_CTOR,
        PN_PTR,
        PN_NUB,
        PN_OUTPARAM,
        PN_REFPARAM,
        PN_ARRAY0,
        PN_ARRAY1,
        PN_ARRAY2,
        PN_INVOKE,
        PN_INDEXERINTERNAL,
        PN_COMBINE,
        PN_REMOVE,

        // CLS method names for user defined operators
        PN_OPUNARYMINUS,
        PN_OPINCREMENT,
        PN_OPDECREMENT,
        PN_OPEQUALITY,
        PN_OPINEQUALITY,

        PN_CONCAT,
        PN_ADD,
        PN_CREATEDELEGATE,
        PN_CAP_VALUE,
        PN_GETVALUE,
        PN_LAMBDA,
        PN_PARAMETER,
        PN_CONSTANT,
        PN_CONVERT,
        PN_CONVERTCHECKED,
        PN_ADDCHECKED,
        PN_DIVIDE,
        PN_MODULO,
        PN_MULTIPLY,
        PN_MULTIPLYCHECKED,
        PN_SUBTRACT,
        PN_SUBTRACTCHECKED,
        PN_AND,
        PN_OR,
        PN_EXCLUSIVEOR,
        PN_LEFTSHIFT,
        PN_RIGHTSHIFT,
        PN_ANDALSO,
        PN_ORELSE,
        PN_EQUAL,
        PN_NOTEQUAL,
        PN_GREATERTHANOREQUAL,
        PN_GREATERTHAN,
        PN_LESSTHAN,
        PN_LESSTHANOREQUAL,
        PN_ARRAYINDEX,
        PN_ASSIGN,
        PN_CAP_FIELD,
        PN_CALL,
        PN_NEW,
        PN_QUOTE,
        PN_PLUS,
        PN_NEGATE,
        PN_NEGATECHECKED,
        PN_NOT,
        PN_NEWARRAYINIT,
        PN_EXPRESSION_PROPERTY,

        PN_ADDEVENTHANDLER,
        PN_REMOVEEVENTHANDLER,
        PN_INVOCATIONLIST,
        PN_GETORCREATEEVENTREGISTRATIONTOKENTABLE,

        PN_COUNT,  // Not a name, this is the total count of predefined names
    }
}
