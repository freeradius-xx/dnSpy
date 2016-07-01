﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using dnSpy.Contracts.Text.Editor;

namespace dnSpy.Contracts.Text.Formatting {
	/// <summary>
	/// Provides the line transform for a line of formatted text
	/// </summary>
	public interface ILineTransformSource {
		/// <summary>
		/// Calculates the line transform for a given line of formatted text
		/// </summary>
		/// <param name="line">The line for which to calculate the line transform</param>
		/// <param name="yPosition">The y-coordinate of the line</param>
		/// <param name="placement">The placement of the line with respect to <paramref name="yPosition"/></param>
		/// <returns></returns>
		LineTransform GetLineTransform(ITextViewLine line, double yPosition, ViewRelativePosition placement);
	}
}
