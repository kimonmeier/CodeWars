# Description

<p>My little sister came back home from school with the following task:
given a squared sheet of paper she has to cut it in pieces
which, when assembled, give squares the sides of which form
an increasing sequence of numbers.
At the beginning it was lot of fun but little by little we were tired of seeing the pile of torn paper.
So we decided to write a program that could help us and protects trees.</p>
<h4 id="task">Task</h4>
<p>Given a positive integral number n, return a <strong>strictly increasing</strong> sequence (list/array/string depending on the language) of numbers, so that the sum of the squares is equal to n².</p>
<p>If there are multiple solutions (and there will be), return as far as possible the result with the largest possible values:</p>
<h4 id="examples">Examples</h4>
<p><code>decompose(11)</code> must return <code>[1,2,4,10]</code>. Note that there are actually two ways to decompose 11²,
11² = 121 = 1 + 4 + 16 + 100 = 1² + 2² + 4² + 10² but don't return <code>[2,6,9]</code>, since 9 is smaller than 10.</p>
<p>For <code>decompose(50)</code> don't return <code>[1, 1, 4, 9, 49]</code> but <code>[1, 3, 5, 8, 49]</code> since <code>[1, 1, 4, 9, 49]</code>
doesn't form a strictly increasing sequence.</p>
<h4 id="note">Note</h4>
<p>Neither <code>[n]</code> nor <code>[1,1,1,…,1]</code> are valid solutions. If no valid solution exists, return <code>nil</code>, <code>null</code>, <code>Nothing</code>, <code>None</code> (depending on the language) or <code>"[]"</code> (C) ,<code>{}</code> (C++), <code>[]</code> (Swift, Go).</p>
<p>The function "decompose" will take a positive integer n 
and return the decomposition of N = n² as:</p>
<ul>
<li>[x1 ... xk]
or</li>
<li>"x1 ... xk"
or</li>
<li>Just [x1 ... xk]
or</li>
<li>Some [x1 ... xk]
or</li>
<li>{x1 ... xk}
or</li>
<li>"[x1,x2, ... ,xk]"</li>
</ul>
<p>depending on the language (see "Sample tests")</p>
<h4 id="note-for-bash">Note for Bash</h4>
<pre><code>decompose 50 returns "1,3,5,8,49"
decompose 4  returns "Nothing"
</code></pre>
<h4 id="hint">Hint</h4>
<p>Very often <code>xk</code> will be <code>n-1</code>.</p>
