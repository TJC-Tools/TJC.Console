﻿namespace TJC.ConsoleApplication.Arguments.Extensions;

internal static class ConsoleArgumentsConversion
{
    /// <summary>
    /// Convert <see cref="ConsoleArguments"/> to <see cref="OptionSet"/>.
    /// </summary>
    /// <param name="arguments">Options</param>
    /// <returns></returns>
    internal static OptionSet ToOptionSet(this List<ConsoleArgument> arguments)
    {
        var optionSet = new OptionSet();
        arguments.ForEach(x => x.AddTo(optionSet));
        return optionSet;
    }

    /// <summary>
    /// Convert a single <see cref="ConsoleArgument"/> to <see cref="OptionSet"/>.
    /// </summary>
    /// <param name="argument">Options</param>
    /// <returns></returns>
    internal static OptionSet ToOptionSet(this ConsoleArgument argument)
    {
        var optionSet = new OptionSet();
        argument.AddTo(optionSet);
        return optionSet;
    }

    /// <summary>
    /// Add a <see cref="ConsoleArgument"/> to <see cref="OptionSet"/>.
    /// </summary>
    /// <param name="option"></param>
    /// <param name="optionSet"></param>
    internal static void AddTo(this ConsoleArgument option, OptionSet optionSet) =>
        optionSet.Add(option.Prototype, option.Description, option.SetOptionValue);
}