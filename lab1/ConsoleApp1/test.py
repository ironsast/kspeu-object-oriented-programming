#include <iostream>
#include <cmath>
#include <functional>
#include <limits>

using namespace std;

// Функция для численного вычисления определённого интеграла функции f
// на интервале [left, right] с шагом step.
static double calculateIntegral(double left, double right, const function<double(double)>& f) {
    double step = 0.0001;  // Задаем шаг интегрирования
    double x = left;  // Начальная точка интегрирования
    double result = 0;  // Переменная для хранения результата интегрирования

    // Проходим по интервалу от left до right с шагом step
    for (; x < right; x += step) {
        result += f(x) * step;  // Добавляем к результату значение функции f(x) умноженное на step
    }

    return result;  // Возвращаем результат интегрирования
}

// Функция для вычисления математического ожидания распределения f
// на интервале [left, right]. Используется численное интегрирование.
static double calculateMean(double left, double right, const function<double(double)>& f) {
    double integral = calculateIntegral(left, right, f);  // Вычисляем интеграл функции f

    // Вычисляем математическое ожидание как отношение интеграла от x*f(x)
    // к интегралу самой функции f на заданном интервале
    return calculateIntegral(left, right, [&f, integral](double x) {
        return x * f(x) / integral;
        });
}

// Функция для вычисления дисперсии распределения f на интервале [left, right].
// В качестве аргумента также передаётся среднее значение (mean).
static double calculateVariance(double left, double right, const function<double(double)>& f, double mean) {
    double integral = calculateIntegral(left, right, f);  // Вычисляем интеграл функции f

    // Вычисляем дисперсию как отношение интеграла от (x - mean)^2 * f(x)
    // к интегралу самой функции f
    return calculateIntegral(left, right, [&f, mean](double x) {
        double diff = x - mean;
        return diff * diff * f(x);
        }) / integral;
}

// Функция для нахождения моды распределения f на интервале [left, right].
// Мода — это точка, в которой функция f достигает своего максимального значения.
static double findMode(double left, double right, const function<double(double)>& f) {
    double step = 0.0001;  // Шаг поиска максимума
    double x = left;  // Начальная точка
    double mode = left;  // Переменная для хранения значения моды
    double currentMax = -numeric_limits<double>::max();  // Переменная для хранения текущего максимума

    // Проходим по интервалу от left до right с шагом step
    for (; x < right; x += step) {
        double value = f(x);  // Вычисляем значение функции в точке x

        // Если текущее значение больше, чем предыдущий максимум, обновляем
        if (value > currentMax) {
            currentMax = value;
            mode = x;  // Обновляем моду
        }
    }

    return mode;  // Возвращаем найденную моду
}

// Функция проверяет, является ли переданная функция f плотностью распределения вероятности.
// Если да, то вычисляет математическое ожидание, дисперсию и моду распределения.
static void processDistribution(double left, double right, const function<double(double)>& f) {
    double integral = calculateIntegral(left, right, f);  // Вычисляем интеграл функции f

    // Проверяем, является ли функция плотностью распределения (интеграл должен быть > 0)
    if (integral <= 0) {
        cout << "Функция не удовлетворяет свойствам плотности распределения вероятности.\n";
        return;
    }

    // Вычисляем математическое ожидание, дисперсию и моду
    double mean = calculateMean(left, right, f);
    double variance = calculateVariance(left, right, f, mean);
    double mode = findMode(left, right, f);

    // Выводим результаты
    cout << "Математическое ожидание: " << mean << endl;
    cout << "Дисперсия: " << variance << endl;
    cout << "Мода: " << mode << endl;
}

int main() {
    setlocale(LC_ALL, "Russian");

    // Распределение 1: проверка функции f1 на интервале [-100, 2]
    double left1 = -100;
    double right1 = 2;
    auto f1 = [](double x) {
        if (x < 0) {
            return 0.0;  // Значение функции за пределами области определения
        }
        else if (x >= 0 && x <= 2) {
            return x - x * x * x / 4.0;  // Определение функции внутри области
        }
        else { return 0.0; }  // Значение функции за пределами области
    };

    cout << "Распределение 1:\n";
    processDistribution(left1, right1, f1);

    // Распределение 2: проверка функции f2 на интервале [0, ?]
    double left2 = 0;
    double right2 = M_PI;
    auto f2 = [](double x) {
        if (x < 0 || x > M_PI) {
            return 0.0;  // Значение функции за пределами области
        } else { return 0.5 * sin(x); }  // Определение функции внутри области
    };

    cout << "\nРаспределение 2:\n";
    processDistribution(left2, right2, f2);

    return 0;
}
