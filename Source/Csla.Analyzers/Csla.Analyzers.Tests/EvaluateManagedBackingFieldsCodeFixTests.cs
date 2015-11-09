﻿using Csla.Analyzers;
using Csla.Analyzers.Tests;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Csla.Analyzers.Tests
{
  [TestClass]
  public sealed class EvaluateManagedBackingFieldsCodeFixTests
  {
    [TestMethod]
    public void VerifyGetFixableDiagnosticIds()
    {
      var fix = new EvaluateManagedBackingFieldsCodeFix();
      var ids = fix.FixableDiagnosticIds.ToList();

      Assert.AreEqual(1, ids.Count, nameof(ids.Count));
      Assert.AreEqual(EvaluateManagedBackingFieldsAnalayzerConstants.DiagnosticId, ids[0],
        nameof(EvaluateManagedBackingFieldsAnalayzerConstants.DiagnosticId));
    }

    [TestMethod]
    public async Task VerifyGetFixes()
    {
      var code = File.ReadAllText(
        $@"Targets\{nameof(EvaluateManagedBackingFieldsCodeFixTests)}\{(nameof(this.VerifyGetFixes))}.cs");
      var document = TestHelpers.Create(code);
      var tree = await document.GetSyntaxTreeAsync();
      var diagnostics = await TestHelpers.GetDiagnosticsAsync(code, new EvaluateManagedBackingFieldsAnalayzer());
      var sourceSpan = diagnostics[0].Location.SourceSpan;

      var actions = new List<CodeAction>();
      var codeActionRegistration = new Action<CodeAction, ImmutableArray<Diagnostic>>(
        (a, _) => { actions.Add(a); });

      var fix = new EvaluateManagedBackingFieldsCodeFix();
      var codeFixContext = new CodeFixContext(document, diagnostics[0],
        codeActionRegistration, new CancellationToken(false));
      await fix.RegisterCodeFixesAsync(codeFixContext);

      Assert.AreEqual(1, actions.Count, nameof(actions.Count));

      await TestHelpers.VerifyActionAsync(actions,
        EvaluateManagedBackingFieldsCodeFixConstants.FixManagedBackingFieldDescription, document,
        tree, new[] { $@"    public readonly static " });
    }
  }
}
